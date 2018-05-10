using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Diagnostics;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;

namespace muratkale.Common
{
    public static class Helper
    {
        private static Dictionary<Type, PropertyInfo[]> _TypesWithWriteableProperties = new Dictionary<Type, PropertyInfo[]>();


        public static Stopwatch time = new Stopwatch();
        public static string Sonuc = "";
        public static string kalanSonuc = "";




        public static string timeCalc()
        {
            time.Stop();
            timeResult();
            time.Reset();
            return Sonuc;
        }

        public static string timeResult()
        {
            TimeSpan h = time.Elapsed;
            Sonuc = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            h.Hours, h.Minutes, h.Seconds, h.Milliseconds / 10);
            return Sonuc;
        }

        public static string timeOrtalamaKalan(double k)
        {
            if (k == 0)
                return kalanSonuc;
            TimeSpan h = time.Elapsed;
            var saat = ((((h.Hours.ToDouble() * 60) * 60) * 100).ToDouble() / k).ToDouble();
            var dakika = (((h.Minutes.ToDouble() * 60) * 100).ToDouble() / k).ToDouble();
            var saniye = (((h.Seconds.ToDouble()) * 100).ToDouble() / k).ToDouble();
            var top = (saat + dakika + saniye).ToString("0.");
            kalanSonuc = top.ToString();
            return kalanSonuc;
        }

        public static double saatdon(double dk, double sn)
        {
            double saat = 0;
            saat = dk / 60.0 + sn / 3600.0;
            return saat;
        }

        public static DataTable ToDataTable<T>(IList<T> data)
        {
            PropertyDescriptorCollection properties =
                TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;
        }

        public static string TestTimeList<T>(this IList<T> list)
        {
            string str = "";
            Helper.time.Start();
            long j = 0;
            while (j < list.Count)
            {
                j++;
            }
            str += "<br> while : " + Helper.timeCalc() + "-" + j;
            j = 0;
            Helper.time.Start();
            for (j = 0; j < list.Count; j++)
            {
            }
            str += "<br> for : " + Helper.timeCalc() + "-" + j;
            j = 0;
            Helper.time.Start();
            foreach (var item in list)
            {
                j++;
            }
            str += "<br> foreach : " + Helper.timeCalc() + "-" + j;

            Helper.time.Start();
            list.ToList().ForEach(o =>
            {
                j++;
            });
            str += "<br> linq foreach :" + Helper.timeCalc() + "-" + j;


            Helper.time.Start();
            Parallel.ForEach(list, x =>
            {
                j++;
            });
            str += "<br> paralel foreach :" + Helper.timeCalc() + "-" + j;


            return str;
        }



        public static bool tcKontrol(this string kimlikno)
        {
            kimlikno = kimlikno.Trim();
            if (kimlikno.Length != 11)
            {
                return false;
            }
            int[] sayilar = new int[11];
            for (int i = 0; i < kimlikno.Length; i++)
            {
                sayilar[i] = Int32.Parse(kimlikno[i].ToString());
            }
            int toplam = 0;
            for (int i = 0; i < kimlikno.Length - 1; i++)
            {
                toplam += sayilar[i];
            }
            if (toplam.ToString()[1].ToString() == sayilar[10].ToString() & sayilar[10] % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Add Quote to string value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string ExQuote(this string value)
        {
            return "'" + value.ToStr() + "'";
        }

        public static int GetNumberDigits(int value)
        {
            if (value < 10) return 10;
            int deger = 1;
            int basamak = 1;
            do
            {
                value /= 10;
                basamak++;

            } while (value > 10);

            for (int i = 0; i < basamak; i++)
            {
                deger *= 10;
            }

            return deger;
        }

        public static string ExToUpper(this string value)
        {
            string deger = string.Empty;
            for (int i = 0; i < value.Length; i++)
            {
                deger += GetUpperChar(value[i]);
            }
            return deger.ToUpper();

        }

        public static string ExToLower(this string value)
        {
            string deger = string.Empty;
            for (int i = 0; i < value.Length; i++)
            {
                deger += GetLowerChar(value[i]);
            }
            return deger;
        }

        private static string GetUpperChar(char value)
        {
            string deger = value.ToString();
            switch (value)
            {
                case 'i': deger = "I"; break;
                default:
                    break;
            }
            return deger;
        }

        private static string GetLowerChar(char value)
        {
            string deger = value.ToString();
            switch (value)
            {
                case 'I': deger = "i"; break;
                default:
                    break;
            }

            return deger.ToLower();
        }


        public static string ToStr(this object key)
        {
            return key == null ? string.Empty : key.ToString();
        }

        public static char ToChar(this object key)
        {
            return Convert.ToChar(key);
        }

        public static string ToStrDate(this DateTime key, string format)
        {
            return key == null ? string.Empty : key.ToString("dd" + format + "MM" + format + "yyyy");
        }

        public static bool ToBoolean(this object key)
        {
            bool deger = false;
            if (key != null)
            {
                if (key.ToString().Contains("True") || key.ToString().Contains("False"))
                {
                    bool.TryParse(key.ToString(), out deger);
                }
                else
                {
                    deger = Convert.ToBoolean(key.ToInt());
                }
            }
            return deger;
        }

        public static int ToInt(this object key)
        {
            int value = 0;
            if (key != null)
                int.TryParse(key.ToString(), out value);
            return value;
        }

        public static int ToInt(this object key, int value)
        {
            int ret = value;
            if (key != null)
            {
                if (!int.TryParse(key.ToString(), out value))
                    value = ret;
            }
            return value;
        }

        public static decimal ToDecimal(this object key, CultureInfo Culture)
        {
            decimal value = 0;
            if (key != null)
                decimal.TryParse(key.ToString(), NumberStyles.Any, Culture, out value);
            return value;
        }

        public static decimal ToDecimal(this object key)
        {
            decimal value = 0;
            if (key != null)
                decimal.TryParse(key.ToString(), NumberStyles.Any, new CultureInfo("tr-TR"), out value);
            return value;
        }

        public static decimal ToDecimal(this object key, decimal value, CultureInfo Culture)
        {
            decimal ret = value;
            if (key != null)
            {
                if (!decimal.TryParse(key.ToString(), NumberStyles.Any, Culture, out value))
                    value = ret;
            }
            return value;
        }

        public static decimal ToDecimal(this object key, decimal value)
        {
            decimal ret = value;
            if (key != null)
            {
                if (!decimal.TryParse(key.ToString(), NumberStyles.Any, new CultureInfo("tr-TR"), out value))
                    value = ret;
            }
            return value;
        }

        public static double ToDouble(this object key)
        {
            double value = 0;
            if (key != null)
                double.TryParse(key.ToString(), NumberStyles.Any, new CultureInfo("tr-TR"), out value);
            return value;
        }

        public static double ToDouble(this object key, CultureInfo Culture)
        {
            double value = 0;
            if (key != null)
                double.TryParse(key.ToString(), NumberStyles.Any, Culture, out value);
            return value;
        }

        public static double ToDouble(this object key, double value, CultureInfo Culture)
        {
            double ret = value;
            if (key != null)
            {
                if (!double.TryParse(key.ToString(), NumberStyles.Any, Culture, out value))
                    value = ret;
            }
            return value;
        }

        public static DateTime? ToDateTime(this object key)
        {
            DateTime? deger = null;
            if (key != null)
            {
                try
                {
                    var date = new DateTime();
                    if (DateTime.TryParse(key.ToString(), out date))
                        return date;
                    else
                        return null;
                }
                catch
                {
                    Console.WriteLine(@"AIop81F9y0ORvI5v98QT");
                }
            }
            return deger;
        }
        public static string ToYMD(this DateTime theDate)
        {
            return theDate.ToString("yyyyMMdd");
        }

        public static string ToYMD(this DateTime? theDate)
        {
            return theDate.HasValue ? theDate.Value.ToYMD() : string.Empty;
        }

        public static int TryParseToInt(this string Deger, int value)
        {
            int.TryParse(Deger, out value);
            return value;
        }

        public static double TryParseToDouble(this string Deger, double value)
        {
            double.TryParse(Deger, out value);
            return value;
        }

        public static decimal TryParseToDecimal(this string deger, decimal value)
        {
            decimal.TryParse(deger, out value);
            return decimal.Round(value, 2);
        }

        public static decimal TryParseToDecimal(this string deger, decimal value, bool round)
        {
            decimal.TryParse(deger, out value);
            if (round) return decimal.Round(value, 2);
            else return value;
        }

        public static string QuotedStr(this object columnValue)
        {
            if (columnValue == null) columnValue = "";
            switch (Type.GetTypeCode(columnValue.GetType()))
            {
                case TypeCode.String:
                    return "'" + EscapeText(columnValue.ToString()) + "'";
                default:
                    return EscapeText(columnValue.ToString());
            }
        }

        public static string EscapeText(string textToEscape)
        {
            string backslashesEscaped = textToEscape.Replace(@"\", @"\\");
            string backslashAndSingleQuoteEscaped = backslashesEscaped.Replace(@"'", @"\'");
            return backslashAndSingleQuoteEscaped;
        }

        public static int ExGetWeekIndex(this DayOfWeek week)
        {
            int value = -1;

            switch (week)
            {
                case DayOfWeek.Friday:
                    value = 4;
                    break;
                case DayOfWeek.Monday:
                    value = 0;
                    break;
                case DayOfWeek.Saturday:
                    value = 5;
                    break;
                case DayOfWeek.Sunday:
                    value = 6;
                    break;
                case DayOfWeek.Thursday:
                    value = 3;
                    break;
                case DayOfWeek.Tuesday:
                    value = 1;
                    break;
                case DayOfWeek.Wednesday:
                    value = 2;
                    break;
                default:
                    break;
            }

            return value;
        }

        public static bool IsDate(String str)
        {
            bool res = false;
            try
            {
                System.DateTime dt = System.DateTime.Parse(str);
                res = true;
            }
            catch
            {
                Console.WriteLine(@"rKrZpQ7cKEdfARKM7swZ");
                // Not a date, handle appropriately
                res = false;
            }
            return res;
        }

        public static bool IsBetween<T>(this T value, T min, T max) where T : IComparable
        {
            //return Comparer<T>.Default.Compare(value, min) >= 0
            //    && Comparer<T>.Default.Compare(value, max) <= 0;
            return (min.CompareTo(value) <= 0) && (value.CompareTo(max) <= 0);
        }

        public static bool InRange<T>(this T value, params T[] values)
        {
            // Should be even number of items
            Debug.Assert(values.Length % 2 == 0);

            for (int i = 0; i < values.Length; i += 2)
                if (!value.InRange(values[i], values[i + 1]))
                    return false;

            return true;
        }

        public static Task<List<T>> ToListAsync<T>(this IQueryable<T> list)
        {
            return Task.Run(() => list.ToList());
        }

        /// <summary>
        /// Verilen doğum tarihine göre yaş bilgisi döner
        /// </summary>
        /// <param name="BirthDate"></param>
        /// <returns></returns>
        public static int ExGetAge(this DateTime? BirthDate)
        {
            if (BirthDate.HasValue)
                return DateTime.Now.Date.Subtract(BirthDate.Value.Date).TotalDays.ToInt() / 365;
            else
                return 0;
        }

        public static int ExGetAge(this DateTime BirthDate)
        {
            return DateTime.Now.Date.Subtract(BirthDate.Date).TotalDays.ToInt() / 365;
        }

        public static int ExGetAge(this DateTime BirthDate, DateTime RegisterDate)
        {
            return RegisterDate.Date.Subtract(BirthDate.Date).TotalDays.ToInt() / 365;
        }

        #region WEBSERVICE

        public static void RemoveTimezoneForDataSet(this DataSet ds)
        {
            foreach (DataTable dt in ds.Tables)
            {
                foreach (DataColumn dc in dt.Columns)
                {

                    if (dc.DataType == typeof(DateTime))
                    {
                        dc.DateTimeMode = DataSetDateTime.Unspecified;
                    }
                }
            }
        }

        #endregion

        #region ENUMS

        public static void ExGetEnumDescription(this string Text, Enum value)
        {
            if (value == null)
                Text = string.Empty;

            FieldInfo fi = value.GetType().GetField(value.ToString());

            if (fi == null)
                Text = string.Empty;

            DescriptionAttribute[] attributes =
                (DescriptionAttribute[])fi.GetCustomAttributes(
                typeof(DescriptionAttribute),
                false);

            if (attributes != null &&
                attributes.Length > 0)
                Text = attributes[0].Description;
            else
                Text = value.ToStr();
        }

        public static string ExGetDescription(this Enum value)
        {
            if (value == null)
                return string.Empty;

            FieldInfo fi = value.GetType().GetField(value.ToString());

            if (fi == null)
                return string.Empty;

            DescriptionAttribute[] attributes =
                (DescriptionAttribute[])fi.GetCustomAttributes(
                typeof(DescriptionAttribute),
                false);

            if (attributes != null &&
                attributes.Length > 0)
                return attributes[0].Description;
            else
                return value.ToStr();
        }

        public static string ExGetDescription(this PropertyInfo property)
        {
            if (property == null)
                return string.Empty;

            DescriptionAttribute[] attributes =
                (DescriptionAttribute[])property.GetCustomAttributes(typeof(DescriptionAttribute), false);

            if (attributes != null &&
                attributes.Length > 0)
                return attributes[0].Description;
            else
                return property.Name.ToStr();
        }

        public static string ExGetDescription(this Type property)
        {
            if (property == null)
                return string.Empty;

            DescriptionAttribute[] attributes =
                (DescriptionAttribute[])property.GetCustomAttributes(typeof(DescriptionAttribute), false);

            if (attributes != null &&
                attributes.Length > 0)
                return attributes[0].Description;
            else
                return property.Name.ToStr();
        }
        #endregion

        #region Data Extension

        public static T NewClass<T>(this T source) where T : class, new()
        {
            var destination = new T();
            PropertyInfo[] properties;
            Type type = typeof(T);
            lock (_TypesWithWriteableProperties)
            {
                if (!_TypesWithWriteableProperties.TryGetValue(type, out properties))
                {
                    List<PropertyInfo> props = new List<PropertyInfo>();
                    PropertyInfo[] classProps = type.GetProperties();
                    foreach (var prop in classProps)
                    {
                        if (prop.CanWrite)
                        {
                            props.Add(prop);
                        }
                    }
                    properties = props.ToArray();
                    _TypesWithWriteableProperties[type] = properties;
                }
            }

            foreach (var prop in properties)
            {
                object value = prop.GetValue(source);
                try
                {
                    prop.SetValue(destination, value);
                }
                catch
                {
                    Console.WriteLine(@"kNWvMLUwguPX9gSnB70n");
                }
            }
            return destination;
        }

        public static T Copy<T, U>(this U source) where T : class, new()
        {
            var destination = new T();
            var destinationProperties = destination.GetType().GetProperties().ToList();
            var sourceProperties = source.GetType().GetProperties().ToList();

            foreach (var destinationProperty in destinationProperties)
            {
                var sourceProperty = sourceProperties.Find(item => item.Name == destinationProperty.Name);

                if (sourceProperty != null && destinationProperty.CanWrite)
                {
                    try
                    {
                        destinationProperty.SetValue(destination, sourceProperty.GetValue(source, null), null);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine(@"QAZlpQtSbuxuePR89Znk");
                    }
                }
            }
            return destination;
        }
        #endregion

        public static List<Dictionary<string, object>> Read(DbDataReader reader)
        {
            List<Dictionary<string, object>> expandolist = new List<Dictionary<string, object>>();
            foreach (var item in reader)
            {
                IDictionary<string, object> expando = new ExpandoObject();
                foreach (PropertyDescriptor propertyDescriptor in TypeDescriptor.GetProperties(item))
                {
                    var obj = propertyDescriptor.GetValue(item);
                    expando.Add(propertyDescriptor.Name, obj);
                }
                expandolist.Add(new Dictionary<string, object>(expando));
            }
            return expandolist;
        }


        public static Dictionary<string, object> DictionaryFromType(this object atype)
        {
            if (atype == null) return new Dictionary<string, object>();
            Type t = atype.GetType();
            PropertyInfo[] props = t.GetProperties();
            Dictionary<string, object> dict = new Dictionary<string, object>();
            foreach (PropertyInfo prp in props)
            {
                object value = prp.GetValue(atype, new object[] { });
                dict.Add(prp.Name, value);
            }
            return dict;
        }


        public static string[] PropertiesFromType(this object atype)
        {
            if (atype == null) return new string[] { };
            Type t = atype.GetType();
            PropertyInfo[] props = t.GetProperties();
            List<string> propNames = new List<string>();
            foreach (PropertyInfo prp in props)
            {
                propNames.Add(prp.Name);
            }
            return propNames.ToArray();
        }

        public static string GetMyTable<T>(this IEnumerable<T> list, params Expression<Func<T, object>>[] fxns)
        {

            StringBuilder sb = new StringBuilder();
            sb.Append("<TABLE>\n");

            sb.Append("<TR>\n");
            foreach (var fxn in fxns)
            {
                sb.Append("<TD>");
                sb.Append(GetName(fxn));
                sb.Append("</TD>");
            }
            sb.Append("</TR> <!-- HEADER -->\n");


            foreach (var item in list)
            {
                sb.Append("<TR>\n");
                foreach (var fxn in fxns)
                {
                    sb.Append("<TD>");
                    sb.Append(fxn.Compile()(item));
                    sb.Append("</TD>");
                }
                sb.Append("</TR>\n");
            }
            sb.Append("</TABLE>");

            return sb.ToString();
        }

        public static string GetName<T>(Expression<Func<T, object>> expr)
        {
            var member = expr.Body as MemberExpression;
            if (member != null)
                return Helper.GetName2(member);

            var unary = expr.Body as UnaryExpression;
            if (unary != null)
                return GetName2((MemberExpression)unary.Operand);

            return "?+?";
        }

        public static string GetName2(MemberExpression member)
        {
            var fieldInfo = member.Member as FieldInfo;
            if (fieldInfo != null)
            {
                var d = fieldInfo.GetCustomAttribute(typeof(DescriptionAttribute)) as DescriptionAttribute;
                if (d != null) return d.Description;
                return fieldInfo.Name;
            }

            var propertInfo = member.Member as PropertyInfo;
            if (propertInfo != null)
            {
                var d = propertInfo.GetCustomAttribute(typeof(DescriptionAttribute)) as DescriptionAttribute;
                if (d != null) return d.Description;
                return propertInfo.Name;
            }

            return "?-?";
        }

        public static string ToEn(this string text)
        {
            return String.Join("", text.Normalize(NormalizationForm.FormD)
            .Where(c => char.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark));
        }

        public static string toTr(this string str)
        {
            string once, sonra;
            once = str;
            sonra = once.Replace('ı', 'i');
            once = sonra.Replace('ö', 'o');
            sonra = once.Replace('ü', 'u');
            once = sonra.Replace('ş', 's');
            sonra = once.Replace('ğ', 'g');
            once = sonra.Replace('ç', 'c');
            sonra = once.Replace('İ', 'I');
            once = sonra.Replace('Ö', 'O');
            sonra = once.Replace('Ü', 'U');
            once = sonra.Replace('Ş', 'S');
            sonra = once.Replace('Ğ', 'G');
            once = sonra.Replace('Ç', 'C');
            str = once;
            return str;

        }

        public static string toCustomTr(this string str)
        {
            str = str.Trim().Replace(".", "").Replace(" ", "").ToLower(new CultureInfo("tr-TR", false)).toTr();
            return str;
        }

        public static void setUrl(this string url)
        {
            System.Diagnostics.Process.Start(url);
        }

        public static string getStr(this string str, string start, string end)
        {
            int first = str.IndexOf(start);
            int last = str.LastIndexOf(end);
            string str2 = str.Substring(first + 1, last - first - 1);
            return str2;
        }

        public static double ToMaxMin(bool durum, params double[] args)
        {
            return durum ? args.ToList().Max() : args.ToList().Min();
        }

        public static List<KeyValuePair<string, string>> GetEnumValuesAndDescriptions<T>()
        {
            Type enumType = typeof(T);

            if (enumType.BaseType != typeof(Enum))
                throw new ArgumentException("T is not System.Enum");

            List<KeyValuePair<string, string>> enumValList = new List<KeyValuePair<string, string>>();

            foreach (var e in Enum.GetValues(typeof(T)))
            {
                var fi = e.GetType().GetField(e.ToString());
                var attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);

                enumValList.Add(new KeyValuePair<string, string>((attributes.Length > 0) ? e.ToString() : e.ToString(), attributes[0].Description));
            }

            return enumValList;
        }

        public static List<string> GetEnumDescriptions<T>()
        {
            Type enumType = typeof(T);

            if (enumType.BaseType != typeof(Enum))
                throw new ArgumentException("T is not System.Enum");

            List<string> enumValList = new List<string>();

            foreach (var e in Enum.GetValues(typeof(T)))
            {
                var fi = e.GetType().GetField(e.ToString());
                var attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);

                enumValList.Add(attributes[0].Description);
            }

            return enumValList;
        }

        public static void SetValueCustom(this object container, string propertyName, object value)
        {
            container.GetType().GetProperty(propertyName).SetValue(container, value, null);
        }

        public static Object GetPropValue(this Object obj, String name)
        {
            foreach (String part in name.Split('.'))
            {
                if (obj == null) { return null; }

                Type type = obj.GetType();
                PropertyInfo info = type.GetProperty(part);
                if (info == null) { return null; }

                obj = info.GetValue(obj, null);
            }
            return obj;
        }



        public static void noSetValueCustom<T>(this object container, string nopropertyName, object value, object total)
        {
            var prop = container.GetType().GetProperties().ToList();
            prop.ForEach(o =>
            {
                if (!nopropertyName.Contains(o.Name) && o.CanWrite)
                {
                    var val = container.GetPropValue(o.Name);
                    if (val != null)
                        container.SetValueCustom(o.Name, (((val.ToDouble() * value.ToDouble())) / total.ToDouble()).ToString("0.##"));
                }
                else
                {
                    var val = container.GetPropValue(o.Name);
                    if (val != null)
                        container.SetValueCustom(o.Name, val);
                }
            });
        }

        public static void noSetValueCustom2<T>(this object container2, List<T> containerList, string nopropertyName, string propertyName)
        {

            container2.GetType().GetProperties().ToList().ForEach(o =>
            {
                if (!nopropertyName.Contains(o.Name) && (!string.IsNullOrEmpty(propertyName) ? propertyName.Contains(o.Name) : true) && o.CanWrite)
                {
                    var total = new List<double>();
                    containerList.Where(l => l.GetType().GetProperty(o.Name).CanWrite).ToList().ForEach(oo =>
                    {
                        var vals = oo.GetPropValue(o.Name).ToDouble();
                        total.Add(vals);
                    });
                    var val = container2.GetPropValue(o.Name).ToDouble();
                    total.Add(val);
                    if (total.Count > 0)
                        container2.SetValueCustom(o.Name, (total.Average()).ToString("0.##"));
                }
                else
                {
                    containerList.ForEach(oo =>
                    {
                        var vals = oo.GetPropValue(o.Name);
                        container2.SetValueCustom(o.Name, vals);
                    });
                }
            });
        }

      


        public static string GetCleanText(this string text)
        {
            string outtext = text.ToLower(System.Globalization.CultureInfo.GetCultureInfo("en"));
            outtext = ClearTurkish(outtext);
            string validchars = "abcdefghijklmnopqrstuvwxyz0123456789";
            string outvalidtext = "";
            for (int x = 0; x < outtext.Length; x++)
                if (validchars.IndexOf(outtext.Substring(x, 1)) != -1)
                    outvalidtext += outtext.Substring(x, 1);
                else
                    outvalidtext += "-";
            return outvalidtext.Replace("---", "-").Replace("--", "-").Replace("+", "_arti_");
        }
        public static string ClearTurkish(this string input)
        {
            return
                StripHtml(input)
                .Replace("Ç", "C")
                .Replace("ç", "c")
                .Replace("Ğ", "G")
                .Replace("ğ", "g")
                .Replace("İ", "I")
                .Replace("ı", "i")
                .Replace("Ö", "ö")
                .Replace("ö", "o")
                .Replace("Ş", "S")
                .Replace("ş", "s")
                .Replace("Ü", "U")
                .Replace("ü", "u")
                .Replace("â", "a")
                .Replace("?", "-")
                .Replace("=", "-")
                .Replace("!", "-")
                .Replace(" ", "-")
                .Replace("&", "-")
                .Replace("%", "-")
                .Replace("\\", "-")
                .Replace("(", "-")
                .Replace(")", "-")
                .Replace("<", "-")
                .Replace(">", "-")
                .Replace("'", "-")
                .Replace("\"", "-")
                .Replace("\n", "-")
                .Replace(".", "-")
                .Replace(",", "-")
                .Replace("@", "-")
                .Replace(":", "-")
                .Replace(";", "-")
                .Replace("“", "-")
                .Replace("”", "-")
                .Replace("/", "-")
                .Replace("+", "_arti_");
        }

        public static string GetCleanTextSearch(this string text)
        {
            string outtext = text.ToLower(System.Globalization.CultureInfo.GetCultureInfo("en"));
            string validchars = "abcçdefgğhıijklmnoöpqrsştuüvwxyz0123456789 ";
            string outvalidtext = "";
            for (int x = 0; x < outtext.Length; x++)
                if (validchars.IndexOf(outtext.Substring(x, 1)) != -1)
                    outvalidtext += text.Substring(x, 1);
                else
                    outvalidtext += "";

            string removedless2chars = "";
            foreach (string holder in outvalidtext.Trim().Split(' '))
            {
                if (holder.Trim().Length > 2)
                {
                    removedless2chars += holder;
                    removedless2chars += " ";
                }
            }
            return removedless2chars.Trim();
        }

        public static string ReplaceIllegalCharacters(this string val, string replaceCharacter = "")
        {
            replaceCharacter = replaceCharacter ?? "";
            val = val.Replace(" ", "")
                        .Replace("!", replaceCharacter)
                        .Replace("'", replaceCharacter)
                        .Replace("^", replaceCharacter)
                        .Replace("%", replaceCharacter)
                        .Replace("&", replaceCharacter)
                        .Replace("/", replaceCharacter)
                        .Replace("(", replaceCharacter)
                        .Replace(")", replaceCharacter)
                        .Replace("=", replaceCharacter)
                        .Replace("?", replaceCharacter)
                        .Replace("<", replaceCharacter)
                        .Replace(">", replaceCharacter)
                        .Replace("£", replaceCharacter)
                        .Replace("#", replaceCharacter)
                        .Replace("½", replaceCharacter)
                        .Replace("{", replaceCharacter)
                        .Replace("[", replaceCharacter)
                        .Replace("]", replaceCharacter)
                        .Replace("}", replaceCharacter)
                        .Replace("\\", replaceCharacter)
                        .Replace("|", replaceCharacter)
                        .Replace("*", replaceCharacter)
                        .Replace("é", replaceCharacter)
                        .Replace("¨", replaceCharacter)
                        .Replace("~", replaceCharacter)
                        .Replace("`", replaceCharacter)
                        .Replace(";", replaceCharacter)
                        .Replace(":", replaceCharacter)
                        .Replace(" ", replaceCharacter);
            return val;
        }

        public static string StripHtml(this string text)
        {
            return Regex.Replace(text, @"<(.|\n)*?>", string.Empty);
        }

        public static string ceoUrl(this string url)
        {
            if (string.IsNullOrEmpty(url)) return "";
            url = url.ToLower();
            url = url.Trim();
            //if (url.Length > 100)
            //{
            //    url = url.Substring(0, 100);
            //}
            url = url.Replace("İ", "I");
            url = url.Replace("ı", "i");
            url = url.Replace("ğ", "g");
            url = url.Replace("Ğ", "G");
            url = url.Replace("ç", "c");
            url = url.Replace("Ç", "C");
            url = url.Replace("ö", "o");
            url = url.Replace("Ö", "O");
            url = url.Replace("ş", "s");
            url = url.Replace("Ş", "S");
            url = url.Replace("ü", "u");
            url = url.Replace("Ü", "U");
            url = url.Replace("'", "");
            url = url.Replace("\"", "");
            char[] replacerList = @"$%#@!*?;:~`+=()[]{}|\'<>,/^&"".".ToCharArray();
            for (int i = 0; i < replacerList.Length; i++)
            {
                string strChr = replacerList[i].ToString();
                if (url.Contains(strChr))
                {
                    url = url.Replace(strChr, string.Empty);
                }
            }
            Regex r = new Regex("[^a-zA-Z0-9_-]");
            url = r.Replace(url, "-");
            while (url.IndexOf("--") > -1)
                url = url.Replace("--", "-");

            return url;
        }

        public static byte[] Serialize(this object item)
        {
            var jsonString = JsonConvert.SerializeObject(item);
            return Encoding.UTF8.GetBytes(jsonString);
        }

        public static T Deserialize<T>(this string serializedObject)
        {
            if (serializedObject == null)
                return default(T);

            //string returnString = "[" + string.Join(",", serializedObject) + "]";

            return JsonConvert.DeserializeObject<T>(serializedObject);
        }

    }

}