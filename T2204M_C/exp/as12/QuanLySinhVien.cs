using System;
using System.IO;
namespace T2204M_C.exp.as12
{
	public class QuanLySinhVien:SinhVien
	{

        private List<SinhVien> ListSinhVien;



        public QuanLySinhVien()
        {
            ListSinhVien = new List<SinhVien>();
        }

        private int GenerateID()
        {
            int max = 1;
            if (ListSinhVien != null && ListSinhVien.Count > 0)
            {
                max = ListSinhVien[0].Id;
                foreach (SinhVien sv in ListSinhVien)
                {
                    if (max < sv.Id)
                    {
                        max = sv.Id;
                    }
                }
                max++;
            }
            return max;
        }

        public SinhVien FindByID(int ID)
        {
            SinhVien searchResult = null;
            if (ListSinhVien != null && ListSinhVien.Count > 0)
            {
                foreach (SinhVien sv in ListSinhVien)
                {
                    if (sv.Id == ID)
                    {
                        searchResult = sv;
                    }
                }
            }
            return searchResult;
        }



        public void UpdateSinhVien(int ID)
        {
            // Tìm kiếm sinh viên trong danh sách ListSinhVien
            SinhVien sv = FindByID(ID);
            // Nếu sinh viên tồn tại thì cập nhập thông tin sinh viên
            if (sv != null)
            {
                Console.Write("Nhap ten sinh vien: ");
                string name = Convert.ToString(Console.ReadLine());
                // Nếu không nhập gì thì không cập nhật tên
                if (name != null && name.Length > 0)
                {
                    sv.Name = name;
                }

                Console.Write("Nhap gioi tinh sinh vien: ");
                // Nếu không nhập gì thì không cập nhật giới tính
                string gender = Convert.ToString(Console.ReadLine());
                if (gender != null && gender.Length > 0)
                {
                    sv.Gender = gender;
                }

                Console.Write("Nhap tuoi sinh vien: ");
                string ageStr = Convert.ToString(Console.ReadLine());
                // Nếu không nhập gì thì không cập nhật tuổi
                if (ageStr != null && ageStr.Length > 0)
                {
                    sv.Age = Convert.ToInt32(ageStr);
                }

                Console.Write("Nhap diem toan: ");
                string diemToanStr = Convert.ToString(Console.ReadLine());
                // Nếu không nhập gì thì không cập nhật điểm toán
                if (diemToanStr != null && diemToanStr.Length > 0)
                {
                    sv.Toan = Convert.ToDouble(diemToanStr);
                }

                Console.Write("Nhap diem ly: ");
                string diemLyStr = Convert.ToString(Console.ReadLine());
                // Nếu không nhập gì thì không cập nhật điểm lý
                if (diemLyStr != null && diemLyStr.Length > 0)
                {
                    sv.Ly = Convert.ToDouble(diemLyStr);
                }

                Console.Write("Nhap diem hoa: ");
                string diemHoaStr = Convert.ToString(Console.ReadLine());
                // Nếu không nhập gì thì không cập nhật điểm hóa
                if (diemHoaStr != null && diemHoaStr.Length > 0)
                {
                    sv.Hoa = Convert.ToDouble(diemHoaStr);
                }

                TinhDTB(sv);
                XepLoaiHocLuc(sv);
            }
            else
            {
                Console.WriteLine("Sinh vien co ID = {0} khong ton tai.", ID);
            }
        }



        public int SoLuongSinhVien()
        {
            int Count = 0;
            if (ListSinhVien != null)
            {
                Count = ListSinhVien.Count;
            }
            return Count;
        }



        private void TinhDTB(SinhVien sv)
        {
            double DiemTB = (sv.Toan + sv.Ly + sv.Hoa) / 3;
            sv.Tb = Math.Round(DiemTB, 2, MidpointRounding.AwayFromZero);
        }


  
        private void XepLoaiHocLuc(SinhVien sv)
        {
            if (sv.Tb >= 8)
            {
                sv.Hocluc = "Gioi";
            }
            else if (sv.Tb >= 6.5)
            {
                sv.Hocluc = "Kha";
            }
            else if (sv.Tb >= 5)
            {
                sv.Hocluc = "Trung Binh";
            }
            else
            {
                sv.Hocluc = "Yeu";
            }
        }


        public void NhapSinhVien()
        {
            // Khởi tạo một sinh viên mới
            SinhVien sv = new SinhVien();
            sv.Id = GenerateID();


            Console.Write("Nhap ten sinh vien: ");
            sv.Name = Convert.ToString(Console.ReadLine());

            Console.Write("Nhap gioi tinh sinh vien: ");
            sv.Gender =Convert.ToString(Console.ReadLine());

            Console.Write("Nhap tuoi sinh vien: ");
            sv.Age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap diem toan: ");
            sv.Toan = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhap diem ly: ");
            sv.Ly = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhap diem hoa: ");
            sv.Hoa = Convert.ToDouble(Console.ReadLine());

            TinhDTB(sv);
            XepLoaiHocLuc(sv);

            ListSinhVien.Add(sv);
        }


        public void SortByDiemTB()
        {
            ListSinhVien.Sort(delegate (SinhVien sv1, SinhVien sv2) {
                return sv1.Tb.CompareTo(sv2.Tb);
            });
        }


  
        public void SortByName()
        {
            ListSinhVien.Sort(delegate (SinhVien sv1, SinhVien sv2) {
                return sv1.Name.CompareTo(sv2.Name);
            });
        }

        public void SortByID()
        {
            ListSinhVien.Sort(delegate (SinhVien sv1, SinhVien sv2) {
                return sv1.Id.CompareTo(sv2.Id);
            });
        }



        public void ShowSinhVien(List<SinhVien> listSV)
        {
            // hien thi tieu de cot
            Console.WriteLine("{0, -5} {1, -20} {2, -5} {3, 5} {4, 5} {5, 5} {6, 5} {7, 10} {8, 10}",
                  "ID", "Name", "Gender", "Age", "Toan", "Ly", "Hoa", "Diem TB", "Hoc Luc");
            // hien thi danh sach sinh vien
            if (listSV != null && listSV.Count > 0)
            {
                foreach (SinhVien sv in listSV)
                { 
                    Console.WriteLine("{0, -5} {1, -20} {2, -5} {3, 5} {4, 5} {5, 5} {6, 5} {7, 10} {8, 10}",
                                      sv.Id, sv.Name, sv.Gender, sv.Age, sv.Toan, sv.Ly, sv.Hoa,
                                      sv.Tb, sv.Hocluc);
                }
            }
            Console.WriteLine();
        }


    }
}

