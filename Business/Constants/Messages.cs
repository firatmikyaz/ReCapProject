using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araç eklendi";
        public static string CarNameInvalid = "Araç ismi geçersiz";
        public static string CarsListed = "arabalar listelendi";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string UserAdded = "Kullanıcı eklendi";
        public static string UserNotDeleted = "Kullanıcı silinmedi";
        public static string UserDeleted = "Kullanıcı silindi";
        public static string UserUpdated = "Kullanıcı güncellendi";
        public static string FirstNameLastNameInvalid = "Kullanıcı adı ve soyadı boş bırakılamaz";
        internal static string CustomerDeleted = "Müşteri silindi";
        internal static string CustomerNotAdded = "Müşteri eklenemedi";
        internal static string CustomerAdded = "Müşteri eklendi";
        internal static string CustomerNotDeleted = "Müşteri silinemedi";
        internal static string CustomersListed = "Müşteriler listelendi";
        internal static string CustomerUpdated = "Müşteri güncellendi";
        internal static string RentalAdded;
        internal static string RentalAddedError;
        internal static string RentalListed;
        internal static string RentalDeleted;
        internal static string RentalUpdated;
        internal static string RentalUpdateReturnDateError;
        internal static string RentalUpdateReturnDate;
    }
}
