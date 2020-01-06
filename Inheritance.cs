// IS-A relationship
// Mammal IS-A animal
// Cat IS-A Mammal
// Therefore Cat IS-A animal

using System;

namespace Inheritance {
    class CodeNationInheritance{
        public void setName(String name) {
            staffName = name;
            studentName = name;
        }
        public void setRole(String role) {
            staffRole = role;
        }
        public void setStartDate(String date) {
            studentStartDate = date;
        }
        protected String staffName;
        protected String staffRole;
        protected String studentStartDate;
        protected String studentName;
    }
    class CodeNationStaff : CodeNationInheritance {
        public String staffInformation() {
            return ($"StaffName: {staffName}, Staff role: {staffRole}");
        }
    }
    class CodeNationStudent : CodeNationInheritance {
        public String studentInformation() {
            return ($"Student Name: {studentName}, Start date: {studentStartDate}");
        }
    }
    class Test {
        static void Main(string [] args) {
            CodeNationStudent jody = new CodeNationStudent();
            jody.setName("Jody");
            jody.setStartDate("21/10/2019");
            Console.WriteLine("Information goes here: {0}", jody.studentInformation());
            CodeNationStaff jacob = new CodeNationStaff();
            jacob.setName("Jacob");
            jacob.setRole("Brew-Boy");
            Console.WriteLine("Information goes here: {0}", jacob.staffInformation());
        }
    }
}

