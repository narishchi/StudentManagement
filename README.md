# StudentManagement

เป็นการบันทึกข้อมูลนักศึกษาลงในลิตส์เเละเเสดงผลนักศึกษาที่มีเกรดเฉลี่ยสูงที่สุด

---

## calss
- class Student(นักศึกษา): ใช้เพื่อเก็บข้อมูลเกี่ยวกับนักศึกษา เช่น รหัสนักศึกษา ชื่อ นามสกุล แผนก และเกรด รวมถึงอาจารย์ที่เป็นที่ปรึกษาของนักศึกษา
- class Professor(อาจารย์):ใช้เพื่อเก็บข้อมูลเกี่ยวกับอาจารย์และจัดการกับนักศึกษาที่เป็นที่ปรึกษาในระบบ เช่น การเพิ่มนักศึกษาในที่ปรึกษาและแสดงรายชื่อนักศึกษาทั้งหมดที่อาจารย์ดูแล
- class Program(โปรเเกรมหลัก): เป็นคลาสที่ใช้ในการทำงานหลักของโปรแกรม โดยจะประกอบไปด้วยเมธอด Main() ซึ่งเป็นจุดเริ่มต้นของการทำงานของโปรแกรม

---
## Class Diagram
class Professor {
    -FirstName: string
    -LastName: string
    -Department: string
    -Advisees: List<Student>
    +AddAdvisee(student: Student)
    +ShowAdvisees()
}

class Student {
    -StudentId: string
    -FirstName: string
    -LastName: string
    -Department: string
    -Grade: double
    -Advisor: Professor
    +ToString(): string
}

class Program {
    +Main(args: string[])
}

Professor "1" *-- "0..*" Student : manages >
Student "1" *-- "1" Professor : advised by >


