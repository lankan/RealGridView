using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
namespace EditableWebgrid.Models
{
    public class UserModel
    {

        [Key]
        public int FileID { get; set; }

        [Required]
        [StringLength(200)]
        public string FileName { get; set; }

        [Required]
        [StringLength(100)]
        public string AutoType { get; set; }

        public DateTime Date { get; set; }

        [StringLength(3)]
        public string Complete { get; set; }

        public DateTime? DateTimeCompleted { get; set; }

        [StringLength(3)]
        public string Operator { get; set; }

        public int? Records { get; set; }

        [StringLength(1)]
        public string SD { get; set; }

        public int? TotalClicks { get; set; }

        [StringLength(3)]
        public string MailingComp { get; set; }

        [StringLength(50)]
        public string MailingOp { get; set; }

        [StringLength(50)]
        public string MailingAsst { get; set; }


        public static List<UserModel> getUsers()
        {
            List<UserModel> users = new List<UserModel>()
            {
                new UserModel (){ FileID=1, FileName="Roeno.pdf", Date=DateTime.Today , Complete = "Yes", DateTimeCompleted = DateTime.Today, Operator = "Sam", Records = 121},
                new UserModel (){ FileID=2, FileName="THaBE.pdf", Date=DateTime.Today , Complete = "No", DateTimeCompleted = DateTime.Today, Operator = "Dan", Records = 129},
                new UserModel (){ FileID=1, FileName="Roeno.pdf", Date=DateTime.Today , Complete = "Yes", DateTimeCompleted = DateTime.Today, Operator = "Sam", Records = 121},
                new UserModel (){ FileID=2, FileName="THaBE.pdf", Date=DateTime.Today , Complete = "No", DateTimeCompleted = DateTime.Today, Operator = "Dan", Records = 129},
                new UserModel (){ FileID=1, FileName="Roeno.pdf", Date=DateTime.Today , Complete = "Yes", DateTimeCompleted = DateTime.Today, Operator = "Sam", Records = 121},
                new UserModel (){ FileID=2, FileName="THaBE.pdf", Date=DateTime.Today , Complete = "No", DateTimeCompleted = DateTime.Today, Operator = "Dan", Records = 129},
                new UserModel (){ FileID=1, FileName="Roeno.pdf", Date=DateTime.Today , Complete = "Yes", DateTimeCompleted = DateTime.Today, Operator = "Sam", Records = 121},
                new UserModel (){ FileID=2, FileName="THaBE.pdf", Date=DateTime.Today , Complete = "No", DateTimeCompleted = DateTime.Today, Operator = "Dan", Records = 129},
                new UserModel (){ FileID=1, FileName="Roeno.pdf", Date=DateTime.Today , Complete = "Yes", DateTimeCompleted = DateTime.Today, Operator = "Sam", Records = 121},
                new UserModel (){ FileID=2, FileName="THaBE.pdf", Date=DateTime.Today , Complete = "No", DateTimeCompleted = DateTime.Today, Operator = "Dan", Records = 129},
                new UserModel (){ FileID=1, FileName="Roeno.pdf", Date=DateTime.Today , Complete = "Yes", DateTimeCompleted = DateTime.Today, Operator = "Sam", Records = 121},
                new UserModel (){ FileID=2, FileName="THaBE.pdf", Date=DateTime.Today , Complete = "No", DateTimeCompleted = DateTime.Today, Operator = "Dan", Records = 129},
                new UserModel (){ FileID=1, FileName="Roeno.pdf", Date=DateTime.Today , Complete = "Yes", DateTimeCompleted = DateTime.Today, Operator = "Sam", Records = 121},
                new UserModel (){ FileID=2, FileName="THaBE.pdf", Date=DateTime.Today , Complete = "No", DateTimeCompleted = DateTime.Today, Operator = "Dan", Records = 129},
                new UserModel (){ FileID=1, FileName="Roeno.pdf", Date=DateTime.Today , Complete = "Yes", DateTimeCompleted = DateTime.Today, Operator = "Sam", Records = 121},
                new UserModel (){ FileID=2, FileName="THaBE.pdf", Date=DateTime.Today , Complete = "No", DateTimeCompleted = DateTime.Today, Operator = "Dan", Records = 129},
                new UserModel (){ FileID=1, FileName="Roeno.pdf", Date=DateTime.Today , Complete = "Yes", DateTimeCompleted = DateTime.Today, Operator = "Sam", Records = 121},
                new UserModel (){ FileID=2, FileName="THaBE.pdf", Date=DateTime.Today , Complete = "No", DateTimeCompleted = DateTime.Today, Operator = "Dan", Records = 129},
                new UserModel (){ FileID=1, FileName="Roeno.pdf", Date=DateTime.Today , Complete = "Yes", DateTimeCompleted = DateTime.Today, Operator = "Sam", Records = 121},
                new UserModel (){ FileID=2, FileName="THaBE.pdf", Date=DateTime.Today , Complete = "No", DateTimeCompleted = DateTime.Today, Operator = "Dan", Records = 129},
                new UserModel (){ FileID=1, FileName="Roeno.pdf", Date=DateTime.Today , Complete = "Yes", DateTimeCompleted = DateTime.Today, Operator = "Sam", Records = 121},
                new UserModel (){ FileID=2, FileName="THaBE.pdf", Date=DateTime.Today , Complete = "No", DateTimeCompleted = DateTime.Today, Operator = "Dan", Records = 129},
                new UserModel (){ FileID=1, FileName="Roeno.pdf", Date=DateTime.Today , Complete = "Yes", DateTimeCompleted = DateTime.Today, Operator = "Sam", Records = 121},
                new UserModel (){ FileID=2, FileName="THaBE.pdf", Date=DateTime.Today , Complete = "No", DateTimeCompleted = DateTime.Today, Operator = "Dan", Records = 129},
                new UserModel (){ FileID=1, FileName="Roeno.pdf", Date=DateTime.Today , Complete = "Yes", DateTimeCompleted = DateTime.Today, Operator = "Sam", Records = 121},
                new UserModel (){ FileID=2, FileName="THaBE.pdf", Date=DateTime.Today , Complete = "No", DateTimeCompleted = DateTime.Today, Operator = "Dan", Records = 129},
                new UserModel (){ FileID=1, FileName="Roeno.pdf", Date=DateTime.Today , Complete = "Yes", DateTimeCompleted = DateTime.Today, Operator = "Sam", Records = 121},
                new UserModel (){ FileID=2, FileName="THaBE.pdf", Date=DateTime.Today , Complete = "No", DateTimeCompleted = DateTime.Today, Operator = "Dan", Records = 129},


            };
            return users;
        }
    }
}