﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;

namespace DNTPersianUtils.Core
{
    /// <summary>
    /// مناسبت‌های تعطیلات رسمی ایران
    /// از سال 1395 تا پایان سال 1398
    /// </summary>
    public static class IranHolidays
    {
        /// <summary>
        /// سال شروع تعاریف مناسبت‌های تعطیل در این کتابخانه
        /// </summary>
        public const int StartYear = 1395;

        /// <summary>
        /// سال خاتمه تعاریف مناسبت‌های تعطیل در این کتابخانه
        /// </summary>
        public const int EndYear = 1400;

        private static readonly Lazy<ISet<IranHoliday>> _holidayProvider =
                new Lazy<ISet<IranHoliday>>(getIranHolidays, LazyThreadSafetyMode.ExecutionAndPublication);

        /// <summary>
        /// مناسبت‌های تعطیلات رسمی ایران
        /// از سال 1395 تا پایان سال 1398
        /// </summary>
        public static ISet<IranHoliday> Instance { get; } = _holidayProvider.Value;

        private static ISet<IranHoliday> getIranHolidays()
        {
            var persianCalendar = new PersianCalendar();

            var holidays = new HashSet<IranHoliday>
            {
                // ----------------------- سال 1395
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1395, 1, 1, 0, 0, 0, 0),
                    Description = "جشن نوروز/جشن سال نو"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1395, 1, 2, 0, 0, 0, 0),
                    Description = "عیدنوروز"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1395, 1, 3, 0, 0, 0, 0),
                    Description = "عیدنوروز"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1395, 1, 4, 0, 0, 0, 0),
                    Description = "عیدنوروز"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1395, 1, 12, 0, 0, 0, 0),
                    Description = "روز جمهوری اسلامی ایران"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1395, 1, 13, 0, 0, 0, 0),
                    Description = "جشن سیزده به در"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1395, 2, 2, 0, 0, 0, 0),
                    Description = "ولادت امام علی علیه السلام و روز پدر"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1395, 2, 16, 0, 0, 0, 0),
                    Description = "مبعث رسول اکرم"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1395, 3, 2, 0, 0, 0, 0),
                    Description = "ولادت حضرت قائم عجل الله تعالی فرجه و جشن نیمه شعبان"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1395, 3, 14, 0, 0, 0, 0),
                    Description = "رحلت حضرت امام خمینی"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1395, 3, 15, 0, 0, 0, 0),
                    Description = "قیام 15 خرداد"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1395, 4, 7, 0, 0, 0, 0),
                    Description = "شهادت حضرت علی علیه السلام"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1395, 4, 16, 0, 0, 0, 0),
                    Description = "عید سعید فطر"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1395, 4, 17, 0, 0, 0, 0),
                    Description = "تعطیل به مناسبت عید سعید فطر"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1395, 5, 9, 0, 0, 0, 0),
                    Description = "شهادت امام جعفر صادق علیه السلام"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1395, 6, 22, 0, 0, 0, 0),
                    Description = "عید سعید قربان"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1395, 6, 30, 0, 0, 0, 0),
                    Description = "عید سعید غدیر خم"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1395, 7, 20, 0, 0, 0, 0),
                    Description = "تاسوعای حسینی"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1395, 7, 21, 0, 0, 0, 0),
                    Description = "عاشورای حسینی"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1395, 8, 30, 0, 0, 0, 0),
                    Description = "اربعین حسینی"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1395, 9, 8, 0, 0, 0, 0),
                    Description = "رحلت رسول اکرم؛ شهادت امام حسن مجتبی علیه السلام"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1395, 9, 10, 0, 0, 0, 0),
                    Description = "شهادت امام رضا علیه السلام"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1395, 9, 27, 0, 0, 0, 0),
                    Description = "میلاد رسول اکرم و امام جعفر صادق علیه السلام"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1395, 10, 5, 0, 0, 0, 0),
                    Description = "زادروز حضرت مسیح"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1395, 11, 22, 0, 0, 0, 0),
                    Description = "پیروزی انقلاب اسلامی"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1395, 12, 12, 0, 0, 0, 0),
                    Description = "شهادت حضرت فاطمه زهرا سلام الله علیها"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1395, 12, 29, 0, 0, 0, 0),
                    Description = "روز ملی شدن صنعت نفت ایران"
                },

                // ----------------------- سال 1396
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1396, 1, 1, 0, 0, 0, 0),
                    Description = "جشن نوروز/جشن سال نو"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1396, 1, 2, 0, 0, 0, 0),
                    Description = "عیدنوروز"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1396, 1, 3, 0, 0, 0, 0),
                    Description = "عیدنوروز"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1396, 1, 4, 0, 0, 0, 0),
                    Description = "عیدنوروز"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1396, 1, 12, 0, 0, 0, 0),
                    Description = "روز جمهوری اسلامی ایران"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1396, 1, 13, 0, 0, 0, 0),
                    Description = "جشن سیزده به در"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1396, 1, 22, 0, 0, 0, 0),
                    Description = "ولادت امام علی علیه السلام و روز پدر"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1396, 2, 5, 0, 0, 0, 0),
                    Description = "مبعث رسول اکرم"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1396, 2, 22, 0, 0, 0, 0),
                    Description = "ولادت حضرت قائم عجل الله تعالی فرجه و جشن نیمه شعبان"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1396, 3, 14, 0, 0, 0, 0),
                    Description = "رحلت حضرت امام خمینی"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1396, 3, 15, 0, 0, 0, 0),
                    Description = "قیام 15 خرداد"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1396, 3, 26, 0, 0, 0, 0),
                    Description = "شهادت حضرت علی علیه السلام"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1396, 4, 5, 0, 0, 0, 0),
                    Description = "عید سعید فطر"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1396, 4, 6, 0, 0, 0, 0),
                    Description = "تعطیل به مناسبت عید سعید فطر"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1396, 4, 29, 0, 0, 0, 0),
                    Description = "شهادت امام جعفر صادق علیه السلام"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1396, 6, 10, 0, 0, 0, 0),
                    Description = "عید سعید قربان"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1396, 6, 18, 0, 0, 0, 0),
                    Description = "عید سعید غدیر خم"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1396, 7, 8, 0, 0, 0, 0),
                    Description = "تاسوعای حسینی"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1396, 7, 9, 0, 0, 0, 0),
                    Description = "عاشورای حسینی"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1396, 8, 18, 0, 0, 0, 0),
                    Description = "اربعین حسینی"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1396, 8, 26, 0, 0, 0, 0),
                    Description = "رحلت رسول اکرم؛ شهادت امام حسن مجتبی علیه السلام"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1396, 8, 28, 0, 0, 0, 0),
                    Description = "شهادت امام رضا علیه السلام"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1396, 9, 6, 0, 0, 0, 0),
                    Description = "شهادت امام حسن‌عسکری و آغاز امامت حضرت ولی‌عصر(عج)"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1396, 9, 15, 0, 0, 0, 0),
                    Description = "میلاد رسول اکرم و امام جعفر صادق علیه السلام"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1396, 11, 22, 0, 0, 0, 0),
                    Description = "پیروزی انقلاب اسلامی"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1396, 12, 1, 0, 0, 0, 0),
                    Description = "شهادت حضرت فاطمه زهرا سلام الله علیها"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1396, 12, 29, 0, 0, 0, 0),
                    Description = "روز ملی شدن صنعت نفت ایران"
                },

                // ----------------------- سال 1397
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1397, 1, 1, 0, 0, 0, 0),
                    Description = "جشن نوروز/جشن سال نو"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1397, 1, 2, 0, 0, 0, 0),
                    Description = "عیدنوروز"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1397, 1, 3, 0, 0, 0, 0),
                    Description = "عیدنوروز"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1397, 1, 4, 0, 0, 0, 0),
                    Description = "عیدنوروز"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1397, 1, 11, 0, 0, 0, 0),
                    Description = "ولادت امام علی علیه السلام و روز پدر"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1397, 1, 12, 0, 0, 0, 0),
                    Description = "روز جمهوری اسلامی ایران"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1397, 1, 13, 0, 0, 0, 0),
                    Description = "جشن سیزده به در"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1397, 1, 25, 0, 0, 0, 0),
                    Description = "مبعث رسول اکرم"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1397, 2, 12, 0, 0, 0, 0),
                    Description = "ولادت حضرت قائم عجل الله تعالی فرجه و جشن نیمه شعبان"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1397, 3, 14, 0, 0, 0, 0),
                    Description = "رحلت حضرت امام خمینی"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1397, 3, 15, 0, 0, 0, 0),
                    Description = "قیام 15 خرداد"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1397, 3, 16, 0, 0, 0, 0),
                    Description = "شهادت حضرت علی علیه السلام"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1397, 3, 25, 0, 0, 0, 0),
                    Description = "عید سعید فطر"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1397, 3, 26, 0, 0, 0, 0),
                    Description = "تعطیل به مناسبت عید سعید فطر"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1397, 4, 18, 0, 0, 0, 0),
                    Description = "شهادت امام جعفر صادق علیه السلام"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1397, 5, 31, 0, 0, 0, 0),
                    Description = "عید سعید قربان"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1397, 6, 8, 0, 0, 0, 0),
                    Description = "عید سعید غدیر خم"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1397, 6, 28, 0, 0, 0, 0),
                    Description = "تاسوعای حسینی"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1397, 6, 29, 0, 0, 0, 0),
                    Description = "عاشورای حسینی"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1397, 8, 8, 0, 0, 0, 0),
                    Description = "اربعین حسینی"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1397, 8, 16, 0, 0, 0, 0),
                    Description = "رحلت رسول اکرم؛ شهادت امام حسن مجتبی علیه السلام"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1397, 8, 17, 0, 0, 0, 0),
                    Description = "شهادت امام رضا علیه السلام"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1397, 8, 25, 0, 0, 0, 0),
                    Description = "شهادت امام حسن‌عسکری و آغاز امامت حضرت ولی‌عصر(عج)"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1397, 9, 4, 0, 0, 0, 0),
                    Description = "میلاد رسول اکرم و امام جعفر صادق علیه السلام"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1397, 11, 20, 0, 0, 0, 0),
                    Description = "شهادت حضرت فاطمه زهرا سلام الله علیها"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1397, 11, 22, 0, 0, 0, 0),
                    Description = "پیروزی انقلاب اسلامی"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1397, 12, 29, 0, 0, 0, 0),
                    Description = "روز ملی شدن صنعت نفت ایران؛ ولادت امام علی علیه السلام و روز پدر"
                },

                // ----------------------- سال 1398
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1398, 1, 1, 0, 0, 0, 0),
                    Description = "جشن نوروز/جشن سال نو"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1398, 1, 2, 0, 0, 0, 0),
                    Description = "عیدنوروز"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1398, 1, 3, 0, 0, 0, 0),
                    Description = "عیدنوروز"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1398, 1, 4, 0, 0, 0, 0),
                    Description = "عیدنوروز"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1398, 1, 12, 0, 0, 0, 0),
                    Description = "روز جمهوری اسلامی ایران"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1398, 1, 13, 0, 0, 0, 0),
                    Description = "جشن سیزده به در"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1398, 1, 14, 0, 0, 0, 0),
                    Description = "مبعث رسول اکرم"
                },

                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1398, 2, 1, 0, 0, 0, 0),
                    Description = "ولادت حضرت قائم عجل الله تعالی فرجه و جشن نیمه شعبان"
                },

                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1398, 3, 6, 0, 0, 0, 0),
                    Description = "شهادت حضرت علی علیه السلام"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1398, 3, 14, 0, 0, 0, 0),
                    Description = "رحلت حضرت امام خمینی"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1398, 3, 15, 0, 0, 0, 0),
                    Description = "قیام 15 خرداد و عید سعید فطر"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1398, 3, 16, 0, 0, 0, 0),
                    Description = "تعطیل به مناسبت عید سعید فطر"
                },

                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1398, 4, 8, 0, 0, 0, 0),
                    Description = "شهادت امام جعفر صادق علیه السلام"
                },

                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1398, 5, 21, 0, 0, 0, 0),
                    Description = "عید سعید قربان"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1398, 5, 29, 0, 0, 0, 0),
                    Description = "عید سعید غدیر خم"
                },


                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1398, 6, 18, 0, 0, 0, 0),
                    Description = "تاسوعای حسینی"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1398, 6, 19, 0, 0, 0, 0),
                    Description = "عاشورای حسینی"
                },

                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1398, 7, 27, 0, 0, 0, 0),
                    Description = "اربعین حسینی"
                },

                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1398, 8, 5, 0, 0, 0, 0),
                    Description = "رحلت رسول اکرم؛ شهادت امام حسن مجتبی علیه السلام"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1398, 8, 7, 0, 0, 0, 0),
                    Description = "شهادت امام رضا علیه السلام"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1398, 8, 15, 0, 0, 0, 0),
                    Description = "شهادت امام حسن‌عسکری و آغاز امامت حضرت ولی‌عصر(عج)"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1398, 8, 24, 0, 0, 0, 0),
                    Description = "میلاد رسول اکرم و امام جعفر صادق علیه السلام"
                },

                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1398, 11, 9, 0, 0, 0, 0),
                    Description = "شهادت حضرت فاطمه زهرا سلام الله علیها"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1398, 11, 22, 0, 0, 0, 0),
                    Description = "پیروزی انقلاب اسلامی"
                },

                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1398, 12, 18, 0, 0, 0, 0),
                    Description = "ولادت امام علی علیه السلام و روز پدر"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1398, 12, 29, 0, 0, 0, 0),
                    Description = "روز ملی شدن صنعت نفت ایران؛ ولادت امام علی علیه السلام و روز پدر"
                },

                // ----------------------- سال 1399
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1399, 1, 1, 0, 0, 0, 0),
                    Description = "جشن نوروز/جشن سال نو"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1399, 1, 2, 0, 0, 0, 0),
                    Description = "عیدنوروز"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1399, 1, 3, 0, 0, 0, 0),
                    Description = "عیدنوروز و مبعث رسول اکرم"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1399, 1, 4, 0, 0, 0, 0),
                    Description = "عیدنوروز"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1399, 1, 12, 0, 0, 0, 0),
                    Description = "روز جمهوری اسلامی ایران"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1399, 1, 13, 0, 0, 0, 0),
                    Description = "جشن سیزده به در"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1399, 1, 21, 0, 0, 0, 0),
                    Description = "ولادت حضرت قائم عجل الله تعالی فرجه و جشن نیمه شعبان"
                },

                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1399, 2, 26, 0, 0, 0, 0),
                    Description = "شهادت حضرت علی علیه السلام"
                },

                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1399, 3, 4, 0, 0, 0, 0),
                    Description = "عید سعید فطر"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1399, 3, 5, 0, 0, 0, 0),
                    Description = "تعطیل به مناسبت عید سعید فطر"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1399, 3, 14, 0, 0, 0, 0),
                    Description = "رحلت حضرت امام خمینی"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1399, 3, 15, 0, 0, 0, 0),
                    Description = "قیام 15 خرداد"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1399, 3, 28, 0, 0, 0, 0),
                    Description = "شهادت امام جعفر صادق علیه السلام"
                },

                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1399, 5, 10, 0, 0, 0, 0),
                    Description = "عید سعید قربان"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1399, 5, 18, 0, 0, 0, 0),
                    Description = "عید سعید غدیر خم"
                },

                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1399, 6, 8, 0, 0, 0, 0),
                    Description = "تاسوعای حسینی"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1399, 6, 9, 0, 0, 0, 0),
                    Description = "عاشورای حسینی"
                },

                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1399, 7, 17, 0, 0, 0, 0),
                    Description = "اربعین حسینی"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1399, 7, 25, 0, 0, 0, 0),
                    Description = "رحلت رسول اکرم؛ شهادت امام حسن مجتبی علیه السلام"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1399, 7, 26, 0, 0, 0, 0),
                    Description = "شهادت امام رضا علیه السلام"
                },

                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1399, 8, 4, 0, 0, 0, 0),
                    Description = "شهادت امام حسن‌عسکری و آغاز امامت حضرت ولی‌عصر(عج)"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1399, 8, 13, 0, 0, 0, 0),
                    Description = "میلاد رسول اکرم و امام جعفر صادق علیه السلام"
                },

                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1399, 10, 28, 0, 0, 0, 0),
                    Description = "شهادت حضرت فاطمه زهرا سلام الله علیها"
                },

                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1399, 11, 22, 0, 0, 0, 0),
                    Description = "پیروزی انقلاب اسلامی"
                },

                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1399, 12, 7, 0, 0, 0, 0),
                    Description = "ولادت امام علی علیه السلام و روز پدر"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1399, 12, 21, 0, 0, 0, 0),
                    Description = "مبعث رسول اکرم"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1399, 12, 29, 0, 0, 0, 0),
                    Description = "روز ملی شدن صنعت نفت ایران"
                },

                // ----------------------- سال 1400
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1400,01,01, 0, 0, 0, 0),
                    Description = "جشن نوروز,جشن سال نو"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1400,01,02, 0, 0, 0, 0),
                    Description = "عیدنوروز"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1400,01,03, 0, 0, 0, 0),
                    Description = "عیدنوروز"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1400,01,04, 0, 0, 0, 0),
                    Description = "عیدنوروز"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1400,01,09, 0, 0, 0, 0),
                    Description = "ولادت حضرت قائم عجل الله تعالی فرجه و جشن نیمه شعبان"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1400,01,12, 0, 0, 0, 0),
                    Description = "روز جمهوری اسلامی ایران"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1400,01,13, 0, 0, 0, 0),
                    Description = "جشن سیزده به در"
                },

                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1400,02,14, 0, 0, 0, 0),
                    Description = "شهادت حضرت علی علیه السلام"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1400,02,23, 0, 0, 0, 0),
                    Description = "عید سعید فطر"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1400,02,24, 0, 0, 0, 0),
                    Description = "تعطیل به مناسبت عید سعید فطر"
                },

                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1400,03,14, 0, 0, 0, 0),
                    Description = "رحلت حضرت امام خمینی"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1400,03,15, 0, 0, 0, 0),
                    Description = "قیام 15 خرداد"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1400,03,16, 0, 0, 0, 0),
                    Description = "شهادت امام جعفر صادق علیه السلام"
                },

                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1400,04,30, 0, 0, 0, 0),
                    Description = "عید سعید قربان"
                },

                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1400,05,07, 0, 0, 0, 0),
                    Description = "عید سعید غدیر خم"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1400,05,27, 0, 0, 0, 0),
                    Description = "تاسوعای حسینی"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1400,05,28, 0, 0, 0, 0),
                    Description = "عاشورای حسینی"
                },

                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1400,07,05, 0, 0, 0, 0),
                    Description = "اربعین حسینی"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1400,07,13, 0, 0, 0, 0),
                    Description = "رحلت رسول اکرم؛ شهادت امام حسن مجتبی علیه السلام"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1400,07,15, 0, 0, 0, 0),
                    Description = "شهادت امام رضا علیه السلام"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1400,07,23, 0, 0, 0, 0),
                    Description = "شهادت امام حسن‌عسکری و آغاز امامت حضرت ولی‌عصر(عج)"
                },

                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1400,08,02, 0, 0, 0, 0),
                    Description = "میلاد رسول اکرم و امام جعفر صادق علیه السلام"
                },

                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1400,10,16, 0, 0, 0, 0),
                    Description = "شهادت حضرت فاطمه زهرا سلام الله علیها"
                },

                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1400,11,22, 0, 0, 0, 0),
                    Description = "پیروزی انقلاب اسلامی"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1400,11,26, 0, 0, 0, 0),
                    Description = "ولادت امام علی علیه السلام و روز پدر"
                },

                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1400,12,10, 0, 0, 0, 0),
                    Description = "مبعث رسول اکرم"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1400,12,27, 0, 0, 0, 0),
                    Description = "ولادت حضرت قائم (عج لالله تعالی) و روز جهانی مستضعفین"
                },
                new IranHoliday
                {
                    Holiday = persianCalendar.ToDateTime(1400,12,29, 0, 0, 0, 0),
                    Description = "روز ملی شدن صنعت نفت ایران"
                },

                // ----------------------- سال 1401
				
		new IranHoliday{ Holiday = persianCalendar.ToDateTime(1401, 01, 01, 0, 0, 0, 0), Description = "جشن نوروز, جشن سال نو" },
		new IranHoliday{ Holiday = persianCalendar.ToDateTime(1401, 01, 02, 0, 0, 0, 0), Description = "عیدنوروز" },
		new IranHoliday{ Holiday = persianCalendar.ToDateTime(1401, 01, 03, 0, 0, 0, 0), Description = "عیدنوروز" },
		new IranHoliday{ Holiday = persianCalendar.ToDateTime(1401, 01, 04, 0, 0, 0, 0), Description = "عیدنوروز" },
		new IranHoliday{ Holiday = persianCalendar.ToDateTime(1401, 01, 12, 0, 0, 0, 0), Description = "روز جمهوری اسلامی ایران" },
		new IranHoliday{ Holiday = persianCalendar.ToDateTime(1401, 01, 13, 0, 0, 0, 0), Description = "جشن سیزده به در" },

		new IranHoliday{ Holiday = persianCalendar.ToDateTime(1401, 02, 03, 0, 0, 0, 0), Description = "شهادت حضرت علی علیه السلام" },
		new IranHoliday{ Holiday = persianCalendar.ToDateTime(1401, 02, 12, 0, 0, 0, 0), Description = "عید سعید فطر" },
		new IranHoliday{ Holiday = persianCalendar.ToDateTime(1401, 02, 13, 0, 0, 0, 0), Description = "تعطیل به مناسبت عید سعید فطر" },

		new IranHoliday{ Holiday = persianCalendar.ToDateTime(1401, 03, 05, 0, 0, 0, 0), Description = "شهادت امام جعفر صادق علیه السلام" },
		new IranHoliday{ Holiday = persianCalendar.ToDateTime(1401, 03, 14, 0, 0, 0, 0), Description = "رحلت حضرت امام خمینی" },
		new IranHoliday{ Holiday = persianCalendar.ToDateTime(1401, 03, 15, 0, 0, 0, 0), Description = "قیام 15 خرداد" },

		new IranHoliday{ Holiday = persianCalendar.ToDateTime(1401, 04, 19, 0, 0, 0, 0), Description = "عید سعید قربان" },
		new IranHoliday{ Holiday = persianCalendar.ToDateTime(1401, 04, 27, 0, 0, 0, 0), Description = "عید سعید غدیر خم" },

		new IranHoliday{ Holiday = persianCalendar.ToDateTime(1401, 05, 16, 0, 0, 0, 0), Description = "تاسوعای حسینی" },
		new IranHoliday{ Holiday = persianCalendar.ToDateTime(1401, 05, 17, 0, 0, 0, 0), Description = "عاشورای حسینی" },

		new IranHoliday{ Holiday = persianCalendar.ToDateTime(1401, 06, 26, 0, 0, 0, 0), Description = "اربعین حسینی" },

		new IranHoliday{ Holiday = persianCalendar.ToDateTime(1401, 07, 03, 0, 0, 0, 0), Description = "رحلت رسول اکرم؛ شهادت امام حسن مجتبی علیه السلام" },
		new IranHoliday{ Holiday = persianCalendar.ToDateTime(1401, 07, 05, 0, 0, 0, 0), Description = "شهادت امام رضا علیه السلام" },
		new IranHoliday{ Holiday = persianCalendar.ToDateTime(1401, 07, 13, 0, 0, 0, 0), Description = "شهادت امام حسن‌عسکری و آغاز امامت حضرت ولی‌عصر(عج)" },
		new IranHoliday{ Holiday = persianCalendar.ToDateTime(1401, 07, 22, 0, 0, 0, 0), Description = "میلاد رسول اکرم و امام جعفر صادق علیه السلام" },

		new IranHoliday{ Holiday = persianCalendar.ToDateTime(1401, 10, 06, 0, 0, 0, 0), Description = "شهادت حضرت فاطمه زهرا سلام الله علیها" },

		new IranHoliday{ Holiday = persianCalendar.ToDateTime(1401, 11, 15, 0, 0, 0, 0), Description = "ولادت امام علی علیه السلام و روز پدر" },
		new IranHoliday{ Holiday = persianCalendar.ToDateTime(1401, 11, 22, 0, 0, 0, 0), Description = "پیروزی انقلاب اسلامی" },
		new IranHoliday{ Holiday = persianCalendar.ToDateTime(1401, 11, 29, 0, 0, 0, 0), Description = "مبعث رسول اکرم" },

		new IranHoliday{ Holiday = persianCalendar.ToDateTime(1401, 12, 17, 0, 0, 0, 0), Description = "ولادت حضرت قائم (عج لالله تعالی)" },
		new IranHoliday{ Holiday = persianCalendar.ToDateTime(1401, 12, 29, 0, 0, 0, 0), Description = "روز ملی شدن صنعت نفت ایران" },

		// ----------------------- سال 1402				
            };

            addFridays(holidays);

            return holidays;
        }

        /// <summary>
        /// لیست مناسبت‌های تعطیلات رسمی ایران در این روز خاص در صورت وجود
        /// از سال 1395 تا پایان سال 1398
        /// </summary>
        /// <param name="date">تاریخ</param>
        /// <param name="convertToIranTimeZone">اگر تاریخ و زمان با فرمت UTC باشند، ابتدا آن‌ها را به منطقه‌ی زمانی ایران تبدیل می‌کند</param>
        public static IEnumerable<string>? GetHolidays(this DateTime date, bool convertToIranTimeZone = true)
        {
            if (date.Kind == DateTimeKind.Utc && convertToIranTimeZone)
            {
                date = date.ToIranTimeZoneDateTime();
            }

            var result = Instance.Where(x => x.Holiday.Year == date.Year &&
                                            x.Holiday.Month == date.Month &&
                                            x.Holiday.Day == date.Day)
                                .Select(x => x.Description)
                                .ToList();
            return result.Count > 0 ? result : null;
        }

#if NET6_0
        /// <summary>
        /// لیست مناسبت‌های تعطیلات رسمی ایران در این روز خاص در صورت وجود
        /// از سال 1395 تا پایان سال 1398
        /// </summary>
        /// <param name="date">تاریخ</param>
        /// <param name="convertToIranTimeZone">اگر تاریخ و زمان با فرمت UTC باشند، ابتدا آن‌ها را به منطقه‌ی زمانی ایران تبدیل می‌کند</param>
        public static IEnumerable<string>? GetHolidays(this DateOnly date, bool convertToIranTimeZone = true)
        {
            return date.ToDateTime().GetHolidays(convertToIranTimeZone);
        }
#endif

        /// <summary>
        /// لیست مناسبت‌های تعطیلات رسمی ایران در این روز خاص در صورت وجود
        /// از سال 1395 تا پایان سال 1398
        /// </summary>
        /// <param name="date">تاریخ</param>
        /// <param name="dateTimeOffsetPart"></param>
        public static IEnumerable<string>? GetHolidays(this DateTimeOffset date, DateTimeOffsetPart dateTimeOffsetPart = DateTimeOffsetPart.IranLocalDateTime)
        {
            var fromDt = date.GetDateTimeOffsetPart(dateTimeOffsetPart);
            return GetHolidays(fromDt);
        }

        /// <summary>
        /// تشخیص تعطیلات رسمی ایران
        /// از سال 1395 تا پایان سال 1398
        /// </summary>
        /// <param name="date">تاریخ</param>
        /// <param name="convertToIranTimeZone">اگر تاریخ و زمان با فرمت UTC باشند، ابتدا آن‌ها را به منطقه‌ی زمانی ایران تبدیل می‌کند</param>
        public static bool IsHoliday(this DateTime date, bool convertToIranTimeZone = true)
        {
            if (date.Kind == DateTimeKind.Utc && convertToIranTimeZone)
            {
                date = date.ToIranTimeZoneDateTime();
            }

            return Instance.Any(x => x.Holiday.Year == date.Year &&
                                    x.Holiday.Month == date.Month &&
                                    x.Holiday.Day == date.Day);
        }

#if NET6_0
        /// <summary>
        /// تشخیص تعطیلات رسمی ایران
        /// از سال 1395 تا پایان سال 1398
        /// </summary>
        /// <param name="date">تاریخ</param>
        /// <param name="convertToIranTimeZone">اگر تاریخ و زمان با فرمت UTC باشند، ابتدا آن‌ها را به منطقه‌ی زمانی ایران تبدیل می‌کند</param>
        public static bool IsHoliday(this DateOnly date, bool convertToIranTimeZone = true)
        {
            return date.ToDateTime().IsHoliday(convertToIranTimeZone);
        }
#endif

        /// <summary>
        /// تشخیص تعطیلات رسمی ایران
        /// از سال 1395 تا پایان سال 1398
        /// </summary>
        /// <param name="date">تاریخ</param>
        /// <param name="dateTimeOffsetPart"></param>
        public static bool IsHoliday(this DateTimeOffset date, DateTimeOffsetPart dateTimeOffsetPart = DateTimeOffsetPart.IranLocalDateTime)
        {
            var fromDt = date.GetDateTimeOffsetPart(dateTimeOffsetPart);
            return IsHoliday(fromDt);
        }

        /// <summary>
        /// دریافت لیست روزهای کاری ایران در یک بازه زمانی
        /// از سال 1395 تا پایان سال 1398
        /// </summary>
        /// <param name="from">از تاریخ</param>
        /// <param name="to">تا تاریخ</param>
        /// <param name="convertToIranTimeZone">اگر تاریخ و زمان با فرمت UTC باشند، ابتدا آن‌ها را به منطقه‌ی زمانی ایران تبدیل می‌کند</param>
        /// <returns>روزهای کاری</returns>
        public static IEnumerable<DateTime> GetBusinessDays(this DateTime from, DateTime to, bool convertToIranTimeZone = true)
        {
            if (from.Kind == DateTimeKind.Utc && convertToIranTimeZone)
            {
                from = from.ToIranTimeZoneDateTime();
            }

            if (to.Kind == DateTimeKind.Utc && convertToIranTimeZone)
            {
                to = to.ToIranTimeZoneDateTime();
            }

            for (var date = from; date <= to; date = date.AddDays(1))
            {
                if (!date.IsHoliday())
                {
                    yield return date;
                }
            }
        }

#if NET6_0
        /// <summary>
        /// دریافت لیست روزهای کاری ایران در یک بازه زمانی
        /// از سال 1395 تا پایان سال 1398
        /// </summary>
        /// <param name="from">از تاریخ</param>
        /// <param name="to">تا تاریخ</param>
        /// <param name="convertToIranTimeZone">اگر تاریخ و زمان با فرمت UTC باشند، ابتدا آن‌ها را به منطقه‌ی زمانی ایران تبدیل می‌کند</param>
        /// <returns>روزهای کاری</returns>
        public static IEnumerable<DateTime> GetBusinessDays(this DateOnly from, DateOnly to, bool convertToIranTimeZone = true)
        {
            return from.ToDateTime().GetBusinessDays(to.ToDateTime(), convertToIranTimeZone);
        }
#endif

        /// <summary>
        /// دریافت لیست روزهای کاری ایران در یک بازه زمانی
        /// از سال 1395 تا پایان سال 1398
        /// </summary>
        /// <param name="from">از تاریخ</param>
        /// <param name="to">تا تاریخ</param>
        /// <param name="dateTimeOffsetPart"></param>
        /// <returns>روزهای کاری</returns>
        public static IEnumerable<DateTime> GetBusinessDays(this DateTimeOffset from, DateTimeOffset to, DateTimeOffsetPart dateTimeOffsetPart = DateTimeOffsetPart.IranLocalDateTime)
        {
            var fromDt = from.GetDateTimeOffsetPart(dateTimeOffsetPart);
            var toDt = to.GetDateTimeOffsetPart(dateTimeOffsetPart);
            return GetBusinessDays(fromDt, toDt);
        }

        /// <summary>
        /// دریافت لیست روزهای کاری ایران در یکسال شمسی
        /// از سال 1395 تا پایان سال 1398
        /// </summary>
        /// <param name="persianYear">سال شمسی</param>
        /// <returns>روزهای کاری</returns>
        public static IEnumerable<DateTime> GetBusinessDays(this int persianYear)
        {
            if (!(persianYear >= StartYear || persianYear <= EndYear))
            {
                throw new ArgumentOutOfRangeException($"در اینجا فقط سال‌های {StartYear} تا {EndYear} پشتیبانی می‌شوند.");
            }

            var persianYearRang = persianYear.GetPersianYearStartAndEndDates();
            var from = persianYearRang.StartDate;
            var to = persianYearRang.EndDate;
            return GetBusinessDays(from, to);
        }

        /// <summary>
        /// دریافت لیست روزهای کاری ایران در یک ماه شمسی
        /// از سال 1395 تا پایان سال 1398
        /// </summary>
        /// <param name="persianYear">سال شمسی</param>
        /// <param name="persianMonth">ماه شمسی</param>
        /// <returns>روزهای کاری</returns>
        public static IEnumerable<DateTime> GetBusinessDays(this int persianYear, int persianMonth)
        {
            if (!(persianYear >= StartYear || persianYear <= EndYear))
            {
                throw new ArgumentOutOfRangeException($"در اینجا فقط سال‌های {StartYear} تا {EndYear} پشتیبانی می‌شوند.");
            }

            var persianMonthRang = persianYear.GetPersianMonthStartAndEndDates(persianMonth);
            var from = persianMonthRang.StartDate;
            var to = persianMonthRang.EndDate;
            return GetBusinessDays(from, to);
        }

        private static void addFridays(HashSet<IranHoliday> holidays)
        {
            var from = StartYear.GetPersianYearStartAndEndDates().StartDate;
            var to = EndYear.GetPersianYearStartAndEndDates().EndDate;
            for (var date = from; date <= to; date = date.AddDays(1))
            {
                if (date.DayOfWeek == DayOfWeek.Friday)
                {
                    holidays.Add(new IranHoliday
                    {
                        Holiday = date,
                        Description = "روز جمعه"
                    });
                }
            }
        }
    }
}