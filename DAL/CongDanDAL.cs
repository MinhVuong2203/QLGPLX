using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CongDanDAL
    {
        public bool ThemCongDan(CongDan congdan)
        {
            try
            {
                DatabaseSession.Context.CongDans.Add(congdan);
                DatabaseSession.Context.SaveChanges();
                return true;
            }
            // Bat lỗi vi phạm ràng buộc cơ sở dữ liệu
            catch (DbUpdateException ex)
            {
                // Bắt lỗi vi phạm ràng buộc SQL (unique, null, check,...)
                if (ex.InnerException != null)
                {
                    string msg = ex.InnerException.Message;

                    if (msg.Contains("CCCD"))
                        throw new Exception("Số CCCD đã tồn tại trong hệ thống!");
                    else if (msg.Contains("Email"))
                        throw new Exception("Email đã tồn tại trong hệ thống!");
                    else if (msg.Contains("SoDienThoai"))
                        throw new Exception("Số điện thoại đã tồn tại trong hệ thống!");
                    else if (msg.Contains("GioiTinh"))
                        throw new Exception("Vui lòng chọn giới tính!");
                    else
                        throw new Exception("Lỗi cơ sở dữ liệu: " + msg);
                }
                else
                {
                    throw new Exception("Lỗi không xác định!");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);                               
            }
        }
    }
}
