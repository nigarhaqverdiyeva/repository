using System.Text.RegularExpressions;

namespace GenericRepository.Entities
{
    public class BaseEntity
    {
        public int Id { get; set; }
    }
    public class Student:BaseEntity
    { 
        public string Name { get; set; }   
        public int GroupId { get; set; }    
        public Group Group { get; set; }
    }
    public class Teacher:BaseEntity
    {    
        public string Name { get; set; }   
        public ICollection<Group> Groups { get; set; }
    }
    public class Group:BaseEntity
    {
    
        public string GroupName { get; set; } 
        public ICollection<Student> Students { get; set; }
        public int TeacherId { get; set; } 
        public Teacher Teacher { get; set; }
    }


}
