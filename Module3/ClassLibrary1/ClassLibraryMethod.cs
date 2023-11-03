using System;
using System.Runtime.CompilerServices;

namespace ClassLibrary1
{
    public class ClassLibraryMethod
    {
        public int getPositionOf2Cir(int firstRadius, int secRadius, int distance)
        {
            if (distance == 0)
            {
                if (firstRadius == secRadius)
                {
                    return 0;
                }
                else if (firstRadius < secRadius)
                {
                    return 1;
                }
                else if (firstRadius > secRadius)
                {
                    return 2;
                }
            }

            if (distance > 0)
            {
                return 3;
            }
            return -1;
        }
        public char checkValues(int X, int Y, int Z)
        {
            if (X == 1 || X == 2)
            {
                return 'A';
            }
            else
            {
                if (Y <= 10)
                {
                    return 'B';
                }
                else
                {
                    if (Z < 5)
                    {
                        return 'C';
                    }
                    else
                    {
                        return 'D';
                    }
                }
            }
        }
        public int max(int a, int b, int c)
        {
            if (a > 0 && b > 0 && c > 0)
            {
                int max = a;
                if (b > max)
                {
                    max = b;
                }
                if (c > max)
                {
                    max = c;
                }
                return max;
            }
            else
            {
                throw new ArgumentException("a, b, and c must be greater than 0");
            }
        }

        public string Triangle(int a, int b, int c)
        {
            int match = 0;
            if (a == b)
                match = match + 1;
            if (a == c)
                match = match + 2;
            if (b == c)
                match = match + 3;
            if (match == 0)
                if ((a + b) <= c)
                    return ("Not a Triangle");
                else if ((b + c) <= a)
                    return ("Not a Triangle");
                else if ((a + c) <= b)
                    return ("Not a Triangle");
                else return ("Triangle is Scalene");
            else if (match == 1)
                 if ((a + c) <= b)
                        return ("Not a Triangle");
                  else return ("Triangle is Isosceles");
            else if (match == 2)
                  if ((a + c) <= b)
                      return ("Not a Triangle");
                   else return ("Triangle is Isosceles");
            else if (match == 3)
                    if ((b + c) <= a)
                          return ("Not a Triangle");
                    else return ("Triangle is Isosceles");
            else return ("Triangle is Equilateral");
        }
        public double Average(double Sum, int Count)
        {
            if (Count == 1)
            {
                return Sum;
            }
            else if (Count > 0)
            {
                return Sum / Count;
            }
            else
            {
                return 0.0;
            }
        }
        public int daysInMonth(int year, int month)
        {
            if (month < 1 || month > 12)
            {
                return 0;
            }

            if (month == 2)
            {
                if ((year % 400 == 0) || ((year % 4 == 0) && (year % 100 != 0)))
                {
                    return 29; 
                }
                else
                {
                    return 28; 
                }
            }

            if (month == 4 || month == 6 || month == 9 || month == 11)
            {
                return 30; 
            }

            return 31;
        }
        public string Solve(float a, float b, float c)
        {
            if (a == 0)
            {
                throw new ArgumentException("Coefficient 'a' cannot be zero");
            }

            float delta = b * b - 4 * a * c;

            if (delta < 0)
            {
                return "no results";
            }
            else if (delta == 0)
            {
                float root = -b / (2 * a);
                return root.ToString(); 
            }
            else
            {
                float root1 = (-b - (float)Math.Sqrt(delta)) / (2 * a);
                float root2 = (-b + (float)Math.Sqrt(delta)) / (2 * a);
                return root1 + ", " + root2;
            }
        }
        public float checkRange(float a, float b, float x)
        {
            if (a > b)
            {
                throw new ArgumentException("a must be less than or equal to b");
            }

            if (x < a)
            {
                return a;
            }
            else if (x > b)
            {
                return b;
            }

            return x;
        }
        public bool isTriangle(float a, float b, float c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                return false;
            }

            if (a + b > c && a + c > b && b + c > a)
            {
                return true;
            }

            return false;
        }
        public float[] centerImage(float w, float h, float ww, float wh)
        {
            if (w <= 0 || h <= 0 || ww <= 0 || wh <= 0)
            {
                throw new ArgumentException("Invalid input values");
            }

            float x, y;

            if (w > ww)
            {
                x = 0;
            }
            else
            {
                x = (ww - w) / 2;
            }

            if (h > wh)
            {
                y = 0;
            }
            else
            {
                y = (wh - h) / 2;
            }

            return new float[] { x, y };
        }

        public int CalculatePrice(int p1, int p2, int p3, int total)
        {
            // Kiểm tra dữ liệu đầu vào hợp lệ
            if (p1 < 0 || p2 < 0 || p3 < 0 || total < 0)
            {
                throw new ArgumentException("Invalid input values");
            }

            if (total <= 100)
            {
                return total * p1;
            }
            else if (total <= 150)
            {
                return 100 * p1 + (total - 100) * p2;
            }
            else
            {
                return 100 * p1 + 50 * p2 + (total - 150) * p3;
            }
        }

        public bool IsPointInRectangle(int x1, int y1, int x2, int y2, int x, int y)
        {
           
            if (x1 > x2 || y1 > y2)
            {
                throw new ArgumentException("Invalid input values");
            }

            
            if (x >= x1 && x <= x2 && y >= y1 && y <= y2)
            {
                return true;
            }

            return false;
        }

        public (float x, float y, float s) CreateIcon(float w, float h)
        {
            if (w <= 0 || h <= 0)
            {
                throw new ArgumentException("Invalid input values");
            }

            float x, y, s;
                
            if (w == h)
            {
                x = 0;
                y = 0;
                s = w;
            }
            else if (w > h)
            {
                x = (w - h) / 2;
                y = 0;
                s = h;
            }
            else
            {
                x = 0;
                y = (h - w) / 2;
                s = w;
            }
            return (x, y, s);

        }

        public bool IsLeapYear(int year)
        {
            if (year < 1000 || year > 10000)
            {
                return false; // Năm nằm ngoài phạm vi từ 1000 đến 10000
            }

            if (year % 100 == 0)
            {
                if (year % 400 != 0)
                {
                    return false; // Năm chia hết cho 100 nhưng không chia hết cho 400
                }
            }

            if (year % 4 == 0)
            {
                return true; // Năm chia hết cho 4
            }

            return false; // Tất cả các trường hợp còn lại
        }

        public bool CheckPassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
            {
                return false; // Mật khẩu không được null hoặc trống
            }

            if (password.Length < 6 || password.Length > 10)
            {
                return false; // Chiều dài mật khẩu không nằm trong khoảng từ 6 đến 10 ký tự
            }

            if (!password.Any(char.IsDigit))
            {
                return false; // Mật khẩu không chứa ít nhất một chữ số
            }

            return true; // Mật khẩu đáp ứng yêu cầu
        }

        public bool IsDateValid(int year, int month, int day)
        {
            if (month >= 1 && month <= 12 && day >= 1 && day <= DaysInMonth(year, month))
            {
                return true;
            }
            return false;
        }

        public int DaysInMonth(int year, int month)
        {
            if (month < 1 || month > 12)
            {
                throw new ArgumentException("Month is out of range");
            }

            if (month == 2)
            {
                if (IsLeapYear1(year))
                {
                    return 29;
                }
                return 28;
            }

            if (month == 4 || month == 6 || month == 9 || month == 11)
            {
                return 30;
            }

            return 31;
        }

        public bool IsLeapYear1(int year)
        {
            if (year % 4 == 0)
            {
                if (year % 100 != 0 || year % 400 == 0)
                {
                    return true;
                }
            }
            return false;
        }

        public bool EmailCheck(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                return false; // Địa chỉ email không được null hoặc trống
            }

            if (email.Contains("..") || email.Contains("@.") || email.Contains(".@") || email.Contains("@@"))
            {
                return false; // Kiểm tra các trường hợp sai về ký tự '.' và '@'
            }

            if (!email.Contains('.') || !email.Contains('@'))
            {
                return false; // Địa chỉ email phải chứa ít nhất một ký tự '.' và một ký tự '@'
            }

            return true; // Địa chỉ email hợp lệ
        }

        public int BodyCheck(short height, int weight)
        {
            if (height <= 0 || weight <= 0)
            {
                return -1; // Dữ liệu không hợp lệ
            }

            // Tính chỉ số BMI (Body Mass Index)
            double bmi = (weight * 10000.0) / (height * height);

            if (bmi < 18.5)
            {
                return 2; // Gầy
            }
            else if (bmi < 24.9)
            {
                return 0; // Bình thường
            }
            else if (bmi < 29.9)
            {
                return 2; // Hơi béo
            }
            else
            {
                return 1; // Béo phì
            }
        }

        public int IsInString(string str, char tmp)
        {
            int pos = -1;
            int i = 0;
            while (i < str.Length)
            {
                if (str[i] == tmp)
                {
                    pos = i;
                    break;
                }
                i++;
            }
            return pos;
        }

    }
}