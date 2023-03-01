using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class BaseEntity
    {
        [Key]
        public int ID { get; set; }
        public DateTimeOffset CreateDate { get; set; }
        public DateTimeOffset UpdateDate { get; set;}
        public Guid CreateUser { get; set; }
        public Guid UpdateUser { get; set; } = Guid.NewGuid();
        public string CreateUserName { get; set; }
        public string UpdateUserName { get; set; }
        public bool IsActive { get; set; }
        public DateTimeOffset ActiveDate { get; set; }
        public DateTimeOffset ActiveTime { get; set;}
        public Guid ActiveedBy { get; set; }
        public string ActiveByUserName { get; set; }
        public bool IsCancled { get; set; }
        public DateTimeOffset CancleDate { get;set; }
        public DateTimeOffset CancleTime { get;set; }
        public Guid CancleUserId { get; set;}
        public string CancleUserName { get; set;}
        public bool IsDeleted { get; set; }
        public DateTimeOffset IsDeletedDate { get; private set; }
        public DateTimeOffset IsDeletedTime { get; private set; }
        public Guid IsDeletedUserId { get; set;}
        public string IsDeletedUserName { get; set;}
        public bool IsSattled { get; set; }
        public DateTimeOffset SattledDate { get; set; }
        public DateTimeOffset SattledTime { get; internal set; }
        public Guid SattledUserId { get; internal set; }
        public string SattledUserName { get; internal set;}
    }
}
