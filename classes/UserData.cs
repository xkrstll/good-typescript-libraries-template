using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMuto.classes
{
    [FirestoreData]
    internal class UserData
    {
        [FirestoreProperty]
        public string AccName { get; set; }
        [FirestoreProperty]
        public string Lastname { get; set; }
        [FirestoreProperty]
        public string AccNum { get; set; }
        [FirestoreProperty]
        public string Address { get; set; }
        [FirestoreProperty]
        public int zip { get; set; }
        [FirestoreProperty]
        public string pin { get; set; }
        [FirestoreProperty]
        public string education { get; set; }
        [FirestoreProperty]
        public string occupation { get; set; }
        [FirestoreProperty]
        public string Phone { get; set; }
        [FirestoreProperty]
        public string dob { get; set; }
    }
}
