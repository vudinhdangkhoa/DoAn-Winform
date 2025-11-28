using System;
using System.IO;
using System.Net.Http;
using System.Windows.Forms;

namespace winform
{
    public partial class ucSaoLuuKhoiPhuc : UserControl
    {
        public ucSaoLuuKhoiPhuc()
        {
            InitializeComponent();
        }

        private async void btnBackup_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Backup Files (*.bak)|*.bak";
                sfd.FileName = $"Backup_{DateTime.Now:yyyyMMdd_HHmm}.bak";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    // Hiển thị trạng thái chờ
                    this.Cursor = Cursors.WaitCursor;
                    btnBackup.Enabled = false;

                    try
                    {
                        using (HttpClient client = new HttpClient())
                        {
                            // Tăng timeout cho việc backup server (phòng khi DB lớn)
                            client.Timeout = TimeSpan.FromMinutes(10);

                            var response = await client.GetAsync(DungChung.getUrl("BackupRestore/backup"));

                            if (response.IsSuccessStatusCode)
                            {
                                var fileBytes = await response.Content.ReadAsByteArrayAsync();
                                File.WriteAllBytes(sfd.FileName, fileBytes);
                                MessageBox.Show("Sao lưu dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                string error = await response.Content.ReadAsStringAsync();
                                MessageBox.Show($"Lỗi Server: {error}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi kết nối: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        this.Cursor = Cursors.Default;
                        btnBackup.Enabled = true;
                    }
                }
            }
        }

        private async void btnRestore_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Backup Files (*.bak)|*.bak";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    if (MessageBox.Show("CẢNH BÁO: Hành động này sẽ ghi đè toàn bộ dữ liệu hiện tại bằng phiên bản sao lưu.\n\nBạn có chắc chắn muốn tiếp tục?",
                        "Xác nhận khôi phục", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    {
                        return;
                    }

                    this.Cursor = Cursors.WaitCursor;
                    btnRestore.Enabled = false;

                    try
                    {
                        // Đọc file (Có thể lớn)
                        // Lưu ý: Nếu file quá lớn (>2GB), nên dùng StreamContent thay vì ByteArrayContent để tránh tràn RAM Client
                        using (var fs = File.OpenRead(ofd.FileName))
                        using (var content = new MultipartFormDataContent())
                        {
                            var streamContent = new StreamContent(fs);
                            streamContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/octet-stream");
                            content.Add(streamContent, "file", Path.GetFileName(ofd.FileName));

                            using (HttpClient client = new HttpClient())
                            {
                                // Timeout cực quan trọng khi Restore (vì upload file + restore DB mất nhiều thời gian)
                                client.Timeout = TimeSpan.FromMinutes(30);

                                var response = await client.PostAsync(DungChung.getUrl("BackupRestore/restore"), content);

                                if (response.IsSuccessStatusCode)
                                {
                                    MessageBox.Show("Khôi phục dữ liệu thành công!\nỨng dụng cần khởi động lại để áp dụng thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Application.Restart(); // Tự động khởi động lại App
                                }
                                else
                                {
                                    string error = await response.Content.ReadAsStringAsync();
                                    MessageBox.Show($"Lỗi Server: {error}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi kết nối hoặc file quá lớn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        this.Cursor = Cursors.Default;
                        btnRestore.Enabled = true;
                    }
                }
            }
        }
    }
}