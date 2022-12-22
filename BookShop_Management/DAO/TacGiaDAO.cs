using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BookShop_Management.DAO
{
    public class TacGiaDAO
    {
        private static TacGiaDAO instance;

        public static TacGiaDAO Instance
        {
            get { if (instance == null) instance = new TacGiaDAO(); return instance; }
            private set { instance = value; }
        }

        private TacGiaDAO() { }

        public List<string> LayDS_TenTacGia()
        {
            List<string> List_TacGia = new List<string>();

            DataTable data = DataProvider.Instance.ExecuteQuery("Select TenTacGia from TacGia");

            foreach (DataRow dr in data.Rows)
                List_TacGia.Add(dr[0].ToString());

            return List_TacGia;
        }

        public bool ThemTacGia(string MaTacGia, string TenTacGia)
        {
            string query = "Insert into TacGia(MaTacGia, TenTacGia) " +
                "values( @MaTacGia , @TenTacGia )";

            if (DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaTacGia, TenTacGia }) > 0)
                return true;

            return false;
        }

        public string LayMaTacGiaTiepTheo()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("Select Top 1(MaTacGia) from TacGia " +
                "Order by MaTacGia DESC");

            string maTacGia = "";
            if (data.Rows.Count != 0)
                maTacGia = data.Rows[0][0].ToString();

            var matches = Regex.Matches(maTacGia, @"\d+");

            string number = "";
            foreach (var match in matches)
                number += match;

            int number_digit;
            if (!int.TryParse(number, out number_digit))
                number_digit = 0;

            number_digit++;

            number = "TG";

            if (number_digit / 100 >= 1)
                number += number_digit.ToString();
            else if (number_digit / 10 >= 1)
                number += ("0" + number_digit.ToString());
            else if (number_digit <= 9)
                number += ("00" + number_digit.ToString());

            return number;
        }

        public string LayMaTacGiaTuTen(string TenTacGia)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("Select MaTacGia from TacGia " +
                "Where TenTacGia = @TenTacGia", new object[] { TenTacGia });

            if (data.Rows.Count != 0) 
                return data.Rows[0][0].ToString();
            return "";
        }

        public string LayTenTacGiaTuMa(string MaTacGia)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("Select TenTacGia from TacGia " +
                "Where MaTacGia = @MaTacGia", new object[] { MaTacGia });

            if(data.Rows.Count != 0)
                return data.Rows[0][0].ToString();
            return "";
        }

    }
}
