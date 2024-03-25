using EMSCT.DATA.Enums;

namespace EMSCT.DATA.Entities.Abstract
{
    public interface IBaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public Status Status { get; set; }
    }
}
