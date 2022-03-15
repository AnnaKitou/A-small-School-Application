using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yourname_individual_part_a.Core.Entities;
using yourname_individual_part_a.Database.PairClasses;

namespace yourname_individual_part_a.Database
{

    class MyDataBase
    {

        public List<Student> Students { get; set; }
        public List<Trainer> Trainers { get; set; }
        public List<Course> Courses { get; set; }
        public List<Assignment> Assignments { get; set; }

        public MyDataBase()
        {

            #region Students DataBase

            Student s1 = new Student(1, "Anna", "Kitou", new DateTime(1989, 10, 16), 3500);
            Student s2 = new Student(2, "Maria", "Kitou", new DateTime(1988, 11, 16), 3000);
            Student s3 = new Student(3, "Anna", "Georgopoulou", new DateTime(1978, 10, 23), 3500);
            Student s4 = new Student(4, "Giannis", "Kotsias", new DateTime(1989, 5, 16), 2550);
            Student s5 = new Student(5, "Giota", "Sotirou", new DateTime(1991, 02, 18), 3500);
            Student s6 = new Student(6, "Kostas", "Koroubalis", new DateTime(1991, 02, 15), 3550);
            Student s7 = new Student(7, "Marios", "Sotiropoulos", new DateTime(1991, 03, 18), 3050);
            Student s8 = new Student(8, "Eleni", "Ksenou", new DateTime(1992, 02, 18), 2500);
            Student s9 = new Student(9, "Despoina", "Kokou", new DateTime(1991, 03, 18), 2800);
            Student s10 = new Student(10, "Stella", "Flesa", new DateTime(1991, 04, 18), 3000);
            Student s11 = new Student(11, "Xristos", "Sotiriou", new DateTime(1991, 09, 13), 3000);
            Student s12 = new Student(12, "Kostas", "Ioannos", new DateTime(1988, 02, 15), 3050);
            Student s13 = new Student(13, "Nikos", "Gioris", new DateTime(1985, 05, 18), 1200);
            Student s14 = new Student(14, "Artemis", "Mageiras", new DateTime(1980, 03, 27), 3500);
            Student s15 = new Student(15, "Tasia", "Tasoulou", new DateTime(1991, 10, 18), 4000);
            Student s16 = new Student(16, "Anaksimandros", "Solos", new DateTime(1991, 11, 18), 4500);
            Student s17 = new Student(17, "Lakis", "Mpoulos", new DateTime(1979, 12, 18), 3100);
            Student s18 = new Student(18, "Takis", "Lokos", new DateTime(1991, 03, 18), 3100);
            Student s19 = new Student(19, "Fotis", "Liakos", new DateTime(1992, 06, 18), 3020);
            Student s20 = new Student(20, "Fotini", "Moriou", new DateTime(1990, 02, 18), 2200);
            Student s21 = new Student(21, "Anna", "Citou", new DateTime(1990, 10, 16), 2500);
            Student s22 = new Student(22, "Maria", "Vitou", new DateTime(1985, 11, 16), 2000);
            Student s23 = new Student(23, "Anna", "Ogopoulou", new DateTime(1980, 10, 23), 4500);
            Student s24 = new Student(24, "Giannis", "Votsias", new DateTime(1979, 5, 16), 5000);
            Student s25 = new Student(25, "Giota", "Tirou", new DateTime(1981, 02, 18), 1500);
            Student s26 = new Student(26, "Kostas", "Roubalis", new DateTime(1981, 02, 15), 1550);
            Student s27 = new Student(27, "Marios", "Sopoulos", new DateTime(1981, 03, 18), 2050);
            Student s28 = new Student(28, "Giota", "Ksenou", new DateTime(1982, 02, 18), 3500);
            Student s29 = new Student(29, "Despoina", "Pokou", new DateTime(1992, 03, 18), 3800);
            Student s30 = new Student(30, "Stella", "Plesa", new DateTime(1989, 04, 18), 4000);
            Student s31 = new Student(31, "Xristos", "Mpiou", new DateTime(1961, 09, 13), 3000);
            Student s32 = new Student(32, "Kostas", "Xoannos", new DateTime(1992, 02, 15), 4050);
            Student s33 = new Student(33, "Nikos", "Voris", new DateTime(1984, 05, 18), 3200);
            Student s34 = new Student(34, "Polos", "Karas", new DateTime(1981, 03, 27), 2500);
            Student s35 = new Student(35, "Taria", "Masoulou", new DateTime(1981, 10, 18), 2000);
            Student s36 = new Student(36, "Anargiros", "Skolos", new DateTime(1981, 11, 18), 2500);
            Student s37 = new Student(37, "Sakis", "Poulos", new DateTime(1989, 12, 18), 2100);
            Student s38 = new Student(38, "Makis", "Rokos", new DateTime(1981, 03, 18), 3100);
            Student s39 = new Student(39, "Fotis", "Tiakos", new DateTime(1982, 06, 18), 2020);
            Student s40 = new Student(40, "Fotini", "Koriou", new DateTime(1980, 02, 18), 4000);

            #endregion

            #region Trainers Database

            Trainer t1 = new Trainer(1, "Leonidas", "Markou", Core.Enums.Subject.Csharp);
            Trainer t2 = new Trainer(2, "Panagiotis", "Markopoulos", Core.Enums.Subject.Javascript);
            Trainer t3 = new Trainer(3, "Eustathios", "Zokou", Core.Enums.Subject.Python);
            Trainer t4 = new Trainer(4, "Leonidas", "Ioannou", Core.Enums.Subject.React);
            Trainer t5 = new Trainer(5, "Maria", "Xitou", Core.Enums.Subject.Python);
            Trainer t6 = new Trainer(6, "Stella", "Tropoglou", Core.Enums.Subject.React);
            Trainer t7 = new Trainer(7, "Eleni", "Gkogkou", Core.Enums.Subject.Javascript);
            Trainer t8 = new Trainer(8, "Elias", "Eliou", Core.Enums.Subject.Csharp);
            #endregion

            #region Courses DataBase
            Course c1 = new Course(1, "C#", Core.Enums.Stream.CB_8, Core.Enums.CourseType.partTime, new DateTime(2019, 01, 01), new DateTime(2019, 03, 31));
            Course c2 = new Course(2, "C#", Core.Enums.Stream.CB_8, Core.Enums.CourseType.fullTime, new DateTime(2019, 01, 01), new DateTime(2019, 03, 31));
            Course c3 = new Course(3, "JavaScript", Core.Enums.Stream.CB_8, Core.Enums.CourseType.partTime, new DateTime(2019, 01, 01), new DateTime(2019, 03, 31));
            Course c4 = new Course(4, "JavaScript", Core.Enums.Stream.CB_8, Core.Enums.CourseType.fullTime, new DateTime(2019, 01, 01), new DateTime(2019, 03, 31));
            Course c5 = new Course(5, "React", Core.Enums.Stream.CB_9, Core.Enums.CourseType.fullTime, new DateTime(2019, 04, 01), new DateTime(2019, 06, 30));
            Course c6 = new Course(6, "React", Core.Enums.Stream.CB_9, Core.Enums.CourseType.partTime, new DateTime(2019, 04, 01), new DateTime(2019, 06, 30));
            Course c7 = new Course(7, "Python", Core.Enums.Stream.CB_9, Core.Enums.CourseType.fullTime, new DateTime(2019, 04, 01), new DateTime(2019, 06, 30));
            Course c8 = new Course(8, "Python", Core.Enums.Stream.CB_9, Core.Enums.CourseType.partTime, new DateTime(2019, 04, 01), new DateTime(2019, 06, 30));
            #endregion

            #region Assignments DataBase
            Assignment a1 = new Assignment(1, "Learning the Basics", new DateTime(2019, 01, 15), 50, 100);
            Assignment a2 = new Assignment(2, "Methods and Functions", new DateTime(2019, 01, 30), 50, 100);
            Assignment a3 = new Assignment(3, "String Methods", new DateTime(2019, 02, 05), 50, 100);
            Assignment a4 = new Assignment(4, "Small App", new DateTime(2019, 02, 15), 60, 100);
            Assignment a5 = new Assignment(5, "Big App", new DateTime(2019, 02, 28), 50, 100);
            Assignment a6 = new Assignment(6, "Project A C#", new DateTime(2019, 03, 15), 40, 100);
            Assignment a7 = new Assignment(7, "Project B C#", new DateTime(2019, 03, 29), 60, 100);

            Assignment a8 = new Assignment(8, "Assignment A", new DateTime(2019, 01, 15), 50, 100);
            Assignment a9 = new Assignment(9, "Class Architecture", new DateTime(2019, 01, 30), 50, 100);
            Assignment a10 = new Assignment(10, "Methods", new DateTime(2019, 02, 05), 50, 100);
            Assignment a11 = new Assignment(11, "Build an App", new DateTime(2019, 02, 15), 60, 100);
            Assignment a12 = new Assignment(12, "Interfaces", new DateTime(2019, 02, 28), 50, 100);
            Assignment a13 = new Assignment(13, "Project A C#", new DateTime(2019, 03, 15), 40, 100);
            Assignment a14 = new Assignment(14, "Project B C#", new DateTime(2019, 03, 29), 60, 100);

            Assignment a15 = new Assignment(15, "Datatypes", new DateTime(2019, 01, 15), 50, 100);
            Assignment a16 = new Assignment(16, "Javascript Basics", new DateTime(2019, 01, 30), 50, 100);
            Assignment a17 = new Assignment(17, "HTML", new DateTime(2019, 02, 05), 50, 100);
            Assignment a18 = new Assignment(18, "Dom Manipulation", new DateTime(2019, 02, 15), 60, 100);
            Assignment a19 = new Assignment(19, "Building Apps", new DateTime(2019, 02, 28), 50, 100);
            Assignment a20 = new Assignment(20, "Project A Javascript", new DateTime(2019, 03, 15), 40, 100);
            Assignment a21 = new Assignment(21, "Project B Javascript", new DateTime(2019, 03, 29), 60, 100);

            Assignment a22 = new Assignment(22, "Step by Step", new DateTime(2019, 01, 15), 50, 100);
            Assignment a23 = new Assignment(23, "From Var to Methods", new DateTime(2019, 01, 30), 50, 100);
            Assignment a24 = new Assignment(24, "Constructors", new DateTime(2019, 02, 05), 50, 100);
            Assignment a25 = new Assignment(25, "Building an App", new DateTime(2019, 02, 15), 60, 100);
            Assignment a26 = new Assignment(26, "Javascript Advanced", new DateTime(2019, 02, 28), 50, 100);
            Assignment a27 = new Assignment(27, "Project A Javascript", new DateTime(2019, 03, 15), 40, 100);
            Assignment a28 = new Assignment(28, "Project B Javascript", new DateTime(2019, 03, 29), 60, 100);

            Assignment a29 = new Assignment(29, "React Basics", new DateTime(2019, 04, 15), 50, 100);
            Assignment a30 = new Assignment(30, "Components", new DateTime(2019, 04, 30), 50, 100);
            Assignment a31 = new Assignment(31, "Rendering", new DateTime(2019, 05, 06), 50, 100);
            Assignment a32 = new Assignment(32, "Building an App in React", new DateTime(2019, 05, 15), 60, 100);
            Assignment a33 = new Assignment(33, "Hooks", new DateTime(2019, 05, 31), 50, 100);
            Assignment a34 = new Assignment(34, "Project A React", new DateTime(2019, 06, 14), 40, 100);
            Assignment a35 = new Assignment(35, "Project B React", new DateTime(2019, 06, 28), 60, 100);

            Assignment a36 = new Assignment(36, "React Basics", new DateTime(2019, 04, 15), 50, 100);
            Assignment a37 = new Assignment(37, "Create Components", new DateTime(2019, 04, 30), 50, 100);
            Assignment a38 = new Assignment(38, "Hooks", new DateTime(2019, 05, 06), 50, 100);
            Assignment a39 = new Assignment(39, "Building an App", new DateTime(2019, 05, 15), 60, 100);
            Assignment a40 = new Assignment(40, "API", new DateTime(2019, 05, 31), 50, 100);
            Assignment a41 = new Assignment(41, "Project A React", new DateTime(2019, 06, 14), 40, 100);
            Assignment a42 = new Assignment(42, "Project B React", new DateTime(2019, 06, 28), 60, 100);

            Assignment a43 = new Assignment(43, "Python Basics", new DateTime(2019, 04, 15), 50, 100);
            Assignment a44 = new Assignment(44, "Create Python", new DateTime(2019, 04, 30), 50, 100);
            Assignment a45 = new Assignment(45, "Python Methods", new DateTime(2019, 05, 06), 50, 100);
            Assignment a46 = new Assignment(46, "Building an App", new DateTime(2019, 05, 15), 60, 100);
            Assignment a47 = new Assignment(47, "Testing", new DateTime(2019, 05, 31), 50, 100);
            Assignment a48 = new Assignment(48, "Project A Python", new DateTime(2019, 06, 14), 40, 100);
            Assignment a49 = new Assignment(49, "Project B Python", new DateTime(2019, 06, 28), 60, 100);

            Assignment a50 = new Assignment(50, "Basics", new DateTime(2019, 04, 15), 50, 100);
            Assignment a51 = new Assignment(51, "Python ", new DateTime(2019, 04, 30), 50, 100);
            Assignment a52 = new Assignment(52, "Basic Structure", new DateTime(2019, 05, 06), 50, 100);
            Assignment a53 = new Assignment(53, "Python Application", new DateTime(2019, 05, 15), 60, 100);
            Assignment a54 = new Assignment(54, "Python Program", new DateTime(2019, 05, 31), 50, 100);
            Assignment a55 = new Assignment(55, "Project A Python", new DateTime(2019, 06, 14), 40, 100);
            Assignment a56 = new Assignment(56, "Project B Python", new DateTime(2019, 06, 28), 60, 100);


            #endregion

            #region Pairing
            #region Pair Course Per Trainer
            //Pair Course Trainer
            CourseTrainer.Pair(c1, t1);
            CourseTrainer.Pair(c2, t8);
            CourseTrainer.Pair(c3, t2);
            CourseTrainer.Pair(c3, t3);
            CourseTrainer.Pair(c4, t7);
            CourseTrainer.Pair(c5, t1);
            CourseTrainer.Pair(c5, t4);
            CourseTrainer.Pair(c6, t6);
            CourseTrainer.Pair(c7, t3);
            CourseTrainer.Pair(c8, t5);
            #endregion


            #region Pair Students Per Course
            //Pair CourseStudent
            CourseStudent.Pair(c1, s1);
            CourseStudent.Pair(c1, s2);
            CourseStudent.Pair(c1, s3);
            CourseStudent.Pair(c1, s4);
            CourseStudent.Pair(c1, s5);
            CourseStudent.Pair(c1, s17);

            CourseStudent.Pair(c2, s6);
            CourseStudent.Pair(c2, s7);
            CourseStudent.Pair(c2, s8);
            CourseStudent.Pair(c2, s9);
            CourseStudent.Pair(c2, s10);

            CourseStudent.Pair(c3, s11);
            CourseStudent.Pair(c3, s12);
            CourseStudent.Pair(c3, s13);
            CourseStudent.Pair(c3, s14);
            CourseStudent.Pair(c3, s15);
            CourseStudent.Pair(c3, s4);
            CourseStudent.Pair(c3, s10);

            CourseStudent.Pair(c4, s16);
            CourseStudent.Pair(c4, s17);
            CourseStudent.Pair(c4, s18);
            CourseStudent.Pair(c4, s19);
            CourseStudent.Pair(c4, s20);
            CourseStudent.Pair(c4, s2);

            CourseStudent.Pair(c5, s21);
            CourseStudent.Pair(c5, s22);
            CourseStudent.Pair(c5, s23);
            CourseStudent.Pair(c5, s24);
            CourseStudent.Pair(c5, s25);

            CourseStudent.Pair(c6, s26);
            CourseStudent.Pair(c6, s27);
            CourseStudent.Pair(c6, s28);
            CourseStudent.Pair(c6, s29);
            CourseStudent.Pair(c6, s30);
            CourseStudent.Pair(c6, s40);

            CourseStudent.Pair(c7, s31);
            CourseStudent.Pair(c7, s32);
            CourseStudent.Pair(c7, s33);
            CourseStudent.Pair(c7, s34);
            CourseStudent.Pair(c7, s35);
            CourseStudent.Pair(c7, s25);

            CourseStudent.Pair(c8, s36);
            CourseStudent.Pair(c8, s37);
            CourseStudent.Pair(c8, s38);
            CourseStudent.Pair(c8, s39);
            CourseStudent.Pair(c8, s40);

            #endregion


            #region Pair Course Per Assignment
            //Pair CourseAssignment
            CourseAssignment.Pair(c1, a1);
            CourseAssignment.Pair(c1, a2);
            CourseAssignment.Pair(c1, a3);
            CourseAssignment.Pair(c1, a4);
            CourseAssignment.Pair(c1, a5);
            CourseAssignment.Pair(c1, a6);
            CourseAssignment.Pair(c1, a7);

            CourseAssignment.Pair(c2, a8);
            CourseAssignment.Pair(c2, a9);
            CourseAssignment.Pair(c2, a10);
            CourseAssignment.Pair(c2, a11);
            CourseAssignment.Pair(c2, a12);
            CourseAssignment.Pair(c2, a13);
            CourseAssignment.Pair(c2, a14);

            CourseAssignment.Pair(c3, a15);
            CourseAssignment.Pair(c3, a16);
            CourseAssignment.Pair(c3, a17);
            CourseAssignment.Pair(c3, a18);
            CourseAssignment.Pair(c3, a19);
            CourseAssignment.Pair(c3, a20);
            CourseAssignment.Pair(c3, a21);

            CourseAssignment.Pair(c4, a22);
            CourseAssignment.Pair(c4, a23);
            CourseAssignment.Pair(c4, a24);
            CourseAssignment.Pair(c4, a25);
            CourseAssignment.Pair(c4, a26);
            CourseAssignment.Pair(c4, a27);
            CourseAssignment.Pair(c4, a28);

            CourseAssignment.Pair(c5, a29);
            CourseAssignment.Pair(c5, a30);
            CourseAssignment.Pair(c5, a31);
            CourseAssignment.Pair(c5, a32);
            CourseAssignment.Pair(c5, a33);
            CourseAssignment.Pair(c5, a34);
            CourseAssignment.Pair(c5, a35);

            CourseAssignment.Pair(c6, a36);
            CourseAssignment.Pair(c6, a37);
            CourseAssignment.Pair(c6, a38);
            CourseAssignment.Pair(c6, a39);
            CourseAssignment.Pair(c6, a40);
            CourseAssignment.Pair(c6, a41);
            CourseAssignment.Pair(c6, a42);

            CourseAssignment.Pair(c7, a43);
            CourseAssignment.Pair(c7, a44);
            CourseAssignment.Pair(c7, a45);
            CourseAssignment.Pair(c7, a46);
            CourseAssignment.Pair(c7, a47);
            CourseAssignment.Pair(c7, a48);
            CourseAssignment.Pair(c7, a49);

            CourseAssignment.Pair(c8, a50);
            CourseAssignment.Pair(c8, a51);
            CourseAssignment.Pair(c8, a52);
            CourseAssignment.Pair(c8, a53);
            CourseAssignment.Pair(c8, a54);
            CourseAssignment.Pair(c8, a55);
            CourseAssignment.Pair(c8, a56);

            #endregion

            #region Pairing Students Per Assignment Per Course
            //Pair StudentPerAssignmentPer Course
            #region Course 1 -Student-Assignment
            AssignmentStudentCourse.Pair(a1, s1, c1);
            AssignmentStudentCourse.Pair(a2, s1, c1);
            AssignmentStudentCourse.Pair(a3, s1, c1);
            AssignmentStudentCourse.Pair(a4, s1, c1);
            AssignmentStudentCourse.Pair(a5, s1, c1);
            AssignmentStudentCourse.Pair(a6, s1, c1);
            AssignmentStudentCourse.Pair(a7, s1, c1);

            AssignmentStudentCourse.Pair(a1, s2, c1);
            AssignmentStudentCourse.Pair(a2, s2, c1);
            AssignmentStudentCourse.Pair(a3, s2, c1);
            AssignmentStudentCourse.Pair(a4, s2, c1);
            AssignmentStudentCourse.Pair(a5, s2, c1);
            AssignmentStudentCourse.Pair(a6, s2, c1);
            AssignmentStudentCourse.Pair(a7, s2, c1);

            AssignmentStudentCourse.Pair(a1, s3, c1);
            AssignmentStudentCourse.Pair(a2, s3, c1);
            AssignmentStudentCourse.Pair(a3, s3, c1);
            AssignmentStudentCourse.Pair(a4, s3, c1);
            AssignmentStudentCourse.Pair(a5, s3, c1);
            AssignmentStudentCourse.Pair(a6, s3, c1);
            AssignmentStudentCourse.Pair(a7, s3, c1);

            AssignmentStudentCourse.Pair(a1, s4, c1);
            AssignmentStudentCourse.Pair(a2, s4, c1);
            AssignmentStudentCourse.Pair(a3, s4, c1);
            AssignmentStudentCourse.Pair(a4, s4, c1);
            AssignmentStudentCourse.Pair(a5, s4, c1);
            AssignmentStudentCourse.Pair(a6, s4, c1);
            AssignmentStudentCourse.Pair(a7, s4, c1);

            AssignmentStudentCourse.Pair(a1, s5, c1);
            AssignmentStudentCourse.Pair(a2, s5, c1);
            AssignmentStudentCourse.Pair(a3, s5, c1);
            AssignmentStudentCourse.Pair(a4, s5, c1);
            AssignmentStudentCourse.Pair(a5, s5, c1);
            AssignmentStudentCourse.Pair(a6, s5, c1);
            AssignmentStudentCourse.Pair(a7, s5, c1);

            AssignmentStudentCourse.Pair(a1, s17, c1);
            AssignmentStudentCourse.Pair(a2, s17, c1);
            AssignmentStudentCourse.Pair(a3, s17, c1);
            AssignmentStudentCourse.Pair(a4, s17, c1);
            AssignmentStudentCourse.Pair(a5, s17, c1);
            AssignmentStudentCourse.Pair(a6, s17, c1);
            AssignmentStudentCourse.Pair(a7, s17, c1);
            #endregion

            #region Course 2 -Student Assignment
            AssignmentStudentCourse.Pair(a8, s6, c2);
            AssignmentStudentCourse.Pair(a9, s6, c2);
            AssignmentStudentCourse.Pair(a10, s6, c2);
            AssignmentStudentCourse.Pair(a11, s6, c2);
            AssignmentStudentCourse.Pair(a12, s6, c2);
            AssignmentStudentCourse.Pair(a13, s6, c2);
            AssignmentStudentCourse.Pair(a14, s6, c2);

            AssignmentStudentCourse.Pair(a8, s7, c2);
            AssignmentStudentCourse.Pair(a9, s7, c2);
            AssignmentStudentCourse.Pair(a10, s7, c2);
            AssignmentStudentCourse.Pair(a11, s7, c2);
            AssignmentStudentCourse.Pair(a12, s7, c2);
            AssignmentStudentCourse.Pair(a13, s7, c2);
            AssignmentStudentCourse.Pair(a14, s7, c2);

            AssignmentStudentCourse.Pair(a8, s8, c2);
            AssignmentStudentCourse.Pair(a9, s8, c2);
            AssignmentStudentCourse.Pair(a10, s8, c2);
            AssignmentStudentCourse.Pair(a11, s8, c2);
            AssignmentStudentCourse.Pair(a12, s8, c2);
            AssignmentStudentCourse.Pair(a13, s8, c2);
            AssignmentStudentCourse.Pair(a14, s8, c2);

            AssignmentStudentCourse.Pair(a8, s9, c2);
            AssignmentStudentCourse.Pair(a9, s9, c2);
            AssignmentStudentCourse.Pair(a10, s9, c2);
            AssignmentStudentCourse.Pair(a11, s9, c2);
            AssignmentStudentCourse.Pair(a12, s9, c2);
            AssignmentStudentCourse.Pair(a13, s9, c2);
            AssignmentStudentCourse.Pair(a14, s9, c2);

            AssignmentStudentCourse.Pair(a8, s10, c2);
            AssignmentStudentCourse.Pair(a9, s10, c2);
            AssignmentStudentCourse.Pair(a10, s10, c2);
            AssignmentStudentCourse.Pair(a11, s10, c2);
            AssignmentStudentCourse.Pair(a12, s10, c2);
            AssignmentStudentCourse.Pair(a13, s10, c2);
            AssignmentStudentCourse.Pair(a14, s10, c2);

            #endregion

            #region Course 3 -Student Assignment

            AssignmentStudentCourse.Pair(a15, s11, c3);
            AssignmentStudentCourse.Pair(a16, s11, c3);
            AssignmentStudentCourse.Pair(a17, s11, c3);
            AssignmentStudentCourse.Pair(a18, s11, c3);
            AssignmentStudentCourse.Pair(a19, s11, c3);
            AssignmentStudentCourse.Pair(a20, s11, c3);
            AssignmentStudentCourse.Pair(a21, s11, c3);

            AssignmentStudentCourse.Pair(a15, s12, c3);
            AssignmentStudentCourse.Pair(a16, s12, c3);
            AssignmentStudentCourse.Pair(a17, s12, c3);
            AssignmentStudentCourse.Pair(a18, s12, c3);
            AssignmentStudentCourse.Pair(a19, s12, c3);
            AssignmentStudentCourse.Pair(a20, s12, c3);
            AssignmentStudentCourse.Pair(a21, s12, c3);

            AssignmentStudentCourse.Pair(a15, s13, c3);
            AssignmentStudentCourse.Pair(a16, s13, c3);
            AssignmentStudentCourse.Pair(a17, s13, c3);
            AssignmentStudentCourse.Pair(a18, s13, c3);
            AssignmentStudentCourse.Pair(a19, s13, c3);
            AssignmentStudentCourse.Pair(a20, s13, c3);
            AssignmentStudentCourse.Pair(a21, s13, c3);

            AssignmentStudentCourse.Pair(a15, s14, c3);
            AssignmentStudentCourse.Pair(a16, s14, c3);
            AssignmentStudentCourse.Pair(a17, s14, c3);
            AssignmentStudentCourse.Pair(a18, s14, c3);
            AssignmentStudentCourse.Pair(a19, s14, c3);
            AssignmentStudentCourse.Pair(a20, s14, c3);
            AssignmentStudentCourse.Pair(a21, s14, c3);

            AssignmentStudentCourse.Pair(a15, s15, c3);
            AssignmentStudentCourse.Pair(a16, s15, c3);
            AssignmentStudentCourse.Pair(a17, s15, c3);
            AssignmentStudentCourse.Pair(a18, s15, c3);
            AssignmentStudentCourse.Pair(a19, s15, c3);
            AssignmentStudentCourse.Pair(a20, s15, c3);
            AssignmentStudentCourse.Pair(a21, s15, c3);

            AssignmentStudentCourse.Pair(a15, s4, c3);
            AssignmentStudentCourse.Pair(a16, s4, c3);
            AssignmentStudentCourse.Pair(a17, s4, c3);
            AssignmentStudentCourse.Pair(a18, s4, c3);
            AssignmentStudentCourse.Pair(a19, s4, c3);
            AssignmentStudentCourse.Pair(a20, s4, c3);
            AssignmentStudentCourse.Pair(a21, s4, c3);

            AssignmentStudentCourse.Pair(a15, s10, c3);
            AssignmentStudentCourse.Pair(a16, s10, c3);
            AssignmentStudentCourse.Pair(a17, s10, c3);
            AssignmentStudentCourse.Pair(a18, s10, c3);
            AssignmentStudentCourse.Pair(a19, s10, c3);
            AssignmentStudentCourse.Pair(a20, s10, c3);
            AssignmentStudentCourse.Pair(a21, s10, c3);
            #endregion

            #region Course 4 -Student Assignment

            AssignmentStudentCourse.Pair(a22, s16, c4);
            AssignmentStudentCourse.Pair(a23, s16, c4);
            AssignmentStudentCourse.Pair(a24, s16, c4);
            AssignmentStudentCourse.Pair(a25, s16, c4);
            AssignmentStudentCourse.Pair(a26, s16, c4);
            AssignmentStudentCourse.Pair(a27, s16, c4);
            AssignmentStudentCourse.Pair(a28, s16, c4);

            AssignmentStudentCourse.Pair(a22, s17, c4);
            AssignmentStudentCourse.Pair(a23, s17, c4);
            AssignmentStudentCourse.Pair(a24, s17, c4);
            AssignmentStudentCourse.Pair(a25, s17, c4);
            AssignmentStudentCourse.Pair(a26, s17, c4);
            AssignmentStudentCourse.Pair(a27, s17, c4);
            AssignmentStudentCourse.Pair(a28, s17, c4);

            AssignmentStudentCourse.Pair(a22, s18, c4);
            AssignmentStudentCourse.Pair(a23, s18, c4);
            AssignmentStudentCourse.Pair(a24, s18, c4);
            AssignmentStudentCourse.Pair(a25, s18, c4);
            AssignmentStudentCourse.Pair(a26, s18, c4);
            AssignmentStudentCourse.Pair(a27, s18, c4);
            AssignmentStudentCourse.Pair(a28, s18, c4);

            AssignmentStudentCourse.Pair(a22, s19, c4);
            AssignmentStudentCourse.Pair(a23, s19, c4);
            AssignmentStudentCourse.Pair(a24, s19, c4);
            AssignmentStudentCourse.Pair(a25, s19, c4);
            AssignmentStudentCourse.Pair(a26, s19, c4);
            AssignmentStudentCourse.Pair(a27, s19, c4);
            AssignmentStudentCourse.Pair(a28, s19, c4);

            AssignmentStudentCourse.Pair(a22, s20, c4);
            AssignmentStudentCourse.Pair(a23, s20, c4);
            AssignmentStudentCourse.Pair(a24, s20, c4);
            AssignmentStudentCourse.Pair(a25, s20, c4);
            AssignmentStudentCourse.Pair(a26, s20, c4);
            AssignmentStudentCourse.Pair(a27, s20, c4);
            AssignmentStudentCourse.Pair(a28, s20, c4);

            AssignmentStudentCourse.Pair(a22, s2, c4);
            AssignmentStudentCourse.Pair(a23, s2, c4);
            AssignmentStudentCourse.Pair(a24, s2, c4);
            AssignmentStudentCourse.Pair(a25, s2, c4);
            AssignmentStudentCourse.Pair(a26, s2, c4);
            AssignmentStudentCourse.Pair(a27, s2, c4);
            AssignmentStudentCourse.Pair(a28, s2, c4);
            #endregion

            #region Course 5 -Student Assignment
            AssignmentStudentCourse.Pair(a29, s21, c5);
            AssignmentStudentCourse.Pair(a30, s21, c5);
            AssignmentStudentCourse.Pair(a31, s21, c5);
            AssignmentStudentCourse.Pair(a32, s21, c5);
            AssignmentStudentCourse.Pair(a33, s21, c5);
            AssignmentStudentCourse.Pair(a34, s21, c5);
            AssignmentStudentCourse.Pair(a35, s21, c5);

            AssignmentStudentCourse.Pair(a29, s22, c5);
            AssignmentStudentCourse.Pair(a30, s22, c5);
            AssignmentStudentCourse.Pair(a31, s22, c5);
            AssignmentStudentCourse.Pair(a32, s22, c5);
            AssignmentStudentCourse.Pair(a33, s22, c5);
            AssignmentStudentCourse.Pair(a34, s22, c5);
            AssignmentStudentCourse.Pair(a35, s22, c5);

            AssignmentStudentCourse.Pair(a29, s23, c5);
            AssignmentStudentCourse.Pair(a30, s23, c5);
            AssignmentStudentCourse.Pair(a31, s23, c5);
            AssignmentStudentCourse.Pair(a32, s23, c5);
            AssignmentStudentCourse.Pair(a33, s23, c5);
            AssignmentStudentCourse.Pair(a34, s23, c5);
            AssignmentStudentCourse.Pair(a35, s23, c5);

            AssignmentStudentCourse.Pair(a29, s24, c5);
            AssignmentStudentCourse.Pair(a30, s24, c5);
            AssignmentStudentCourse.Pair(a31, s24, c5);
            AssignmentStudentCourse.Pair(a32, s24, c5);
            AssignmentStudentCourse.Pair(a33, s24, c5);
            AssignmentStudentCourse.Pair(a34, s24, c5);
            AssignmentStudentCourse.Pair(a35, s24, c5);

            AssignmentStudentCourse.Pair(a29, s25, c5);
            AssignmentStudentCourse.Pair(a30, s25, c5);
            AssignmentStudentCourse.Pair(a31, s25, c5);
            AssignmentStudentCourse.Pair(a32, s25, c5);
            AssignmentStudentCourse.Pair(a33, s25, c5);
            AssignmentStudentCourse.Pair(a34, s25, c5);
            AssignmentStudentCourse.Pair(a35, s25, c5);



            #endregion

            #region Course 6 -Student Assignment

            AssignmentStudentCourse.Pair(a36, s26, c6);
            AssignmentStudentCourse.Pair(a37, s26, c6);
            AssignmentStudentCourse.Pair(a38, s26, c6);
            AssignmentStudentCourse.Pair(a39, s26, c6);
            AssignmentStudentCourse.Pair(a40, s26, c6);
            AssignmentStudentCourse.Pair(a41, s26, c6);
            AssignmentStudentCourse.Pair(a42, s26, c6);

            AssignmentStudentCourse.Pair(a36, s27, c6);
            AssignmentStudentCourse.Pair(a37, s27, c6);
            AssignmentStudentCourse.Pair(a38, s27, c6);
            AssignmentStudentCourse.Pair(a39, s27, c6);
            AssignmentStudentCourse.Pair(a40, s27, c6);
            AssignmentStudentCourse.Pair(a41, s27, c6);
            AssignmentStudentCourse.Pair(a42, s27, c6);

            AssignmentStudentCourse.Pair(a36, s28, c6);
            AssignmentStudentCourse.Pair(a37, s28, c6);
            AssignmentStudentCourse.Pair(a38, s28, c6);
            AssignmentStudentCourse.Pair(a39, s28, c6);
            AssignmentStudentCourse.Pair(a40, s28, c6);
            AssignmentStudentCourse.Pair(a41, s28, c6);
            AssignmentStudentCourse.Pair(a42, s28, c6);

            AssignmentStudentCourse.Pair(a36, s29, c6);
            AssignmentStudentCourse.Pair(a37, s29, c6);
            AssignmentStudentCourse.Pair(a38, s29, c6);
            AssignmentStudentCourse.Pair(a39, s29, c6);
            AssignmentStudentCourse.Pair(a40, s29, c6);
            AssignmentStudentCourse.Pair(a41, s29, c6);
            AssignmentStudentCourse.Pair(a42, s29, c6);

            AssignmentStudentCourse.Pair(a36, s30, c6);
            AssignmentStudentCourse.Pair(a37, s30, c6);
            AssignmentStudentCourse.Pair(a38, s30, c6);
            AssignmentStudentCourse.Pair(a39, s30, c6);
            AssignmentStudentCourse.Pair(a40, s30, c6);
            AssignmentStudentCourse.Pair(a41, s30, c6);
            AssignmentStudentCourse.Pair(a42, s30, c6);

            AssignmentStudentCourse.Pair(a36, s40, c6);
            AssignmentStudentCourse.Pair(a37, s40, c6);
            AssignmentStudentCourse.Pair(a38, s40, c6);
            AssignmentStudentCourse.Pair(a39, s40, c6);
            AssignmentStudentCourse.Pair(a40, s40, c6);
            AssignmentStudentCourse.Pair(a41, s40, c6);
            AssignmentStudentCourse.Pair(a42, s40, c6);

            #endregion

            #region Course 7 -Student Assignment
            AssignmentStudentCourse.Pair(a43, s31, c7);
            AssignmentStudentCourse.Pair(a44, s31, c7);
            AssignmentStudentCourse.Pair(a45, s31, c7);
            AssignmentStudentCourse.Pair(a46, s31, c7);
            AssignmentStudentCourse.Pair(a47, s31, c7);
            AssignmentStudentCourse.Pair(a48, s31, c7);
            AssignmentStudentCourse.Pair(a49, s31, c7);

            AssignmentStudentCourse.Pair(a43, s32, c7);
            AssignmentStudentCourse.Pair(a44, s32, c7);
            AssignmentStudentCourse.Pair(a45, s32, c7);
            AssignmentStudentCourse.Pair(a46, s32, c7);
            AssignmentStudentCourse.Pair(a47, s32, c7);
            AssignmentStudentCourse.Pair(a48, s32, c7);
            AssignmentStudentCourse.Pair(a49, s32, c7);

            AssignmentStudentCourse.Pair(a43, s33, c7);
            AssignmentStudentCourse.Pair(a44, s33, c7);
            AssignmentStudentCourse.Pair(a45, s33, c7);
            AssignmentStudentCourse.Pair(a46, s33, c7);
            AssignmentStudentCourse.Pair(a47, s33, c7);
            AssignmentStudentCourse.Pair(a48, s33, c7);
            AssignmentStudentCourse.Pair(a49, s33, c7);

            AssignmentStudentCourse.Pair(a43, s34, c7);
            AssignmentStudentCourse.Pair(a44, s34, c7);
            AssignmentStudentCourse.Pair(a45, s34, c7);
            AssignmentStudentCourse.Pair(a46, s34, c7);
            AssignmentStudentCourse.Pair(a47, s34, c7);
            AssignmentStudentCourse.Pair(a48, s34, c7);
            AssignmentStudentCourse.Pair(a49, s34, c7);

            AssignmentStudentCourse.Pair(a43, s35, c7);
            AssignmentStudentCourse.Pair(a44, s35, c7);
            AssignmentStudentCourse.Pair(a45, s35, c7);
            AssignmentStudentCourse.Pair(a46, s35, c7);
            AssignmentStudentCourse.Pair(a47, s35, c7);
            AssignmentStudentCourse.Pair(a48, s35, c7);
            AssignmentStudentCourse.Pair(a49, s35, c7);

            AssignmentStudentCourse.Pair(a43, s25, c7);
            AssignmentStudentCourse.Pair(a44, s25, c7);
            AssignmentStudentCourse.Pair(a45, s25, c7);
            AssignmentStudentCourse.Pair(a46, s25, c7);
            AssignmentStudentCourse.Pair(a47, s25, c7);
            AssignmentStudentCourse.Pair(a48, s25, c7);
            AssignmentStudentCourse.Pair(a49, s25, c7);

            #endregion

            #region Course 8 -Student Assignment
            AssignmentStudentCourse.Pair(a50, s36, c8);
            AssignmentStudentCourse.Pair(a51, s36, c8);
            AssignmentStudentCourse.Pair(a52, s36, c8);
            AssignmentStudentCourse.Pair(a53, s36, c8);
            AssignmentStudentCourse.Pair(a54, s36, c8);
            AssignmentStudentCourse.Pair(a55, s36, c8);
            AssignmentStudentCourse.Pair(a56, s36, c8);

            AssignmentStudentCourse.Pair(a50, s37, c8);
            AssignmentStudentCourse.Pair(a51, s37, c8);
            AssignmentStudentCourse.Pair(a52, s37, c8);
            AssignmentStudentCourse.Pair(a53, s37, c8);
            AssignmentStudentCourse.Pair(a54, s37, c8);
            AssignmentStudentCourse.Pair(a55, s37, c8);
            AssignmentStudentCourse.Pair(a56, s37, c8);

            AssignmentStudentCourse.Pair(a50, s38, c8);
            AssignmentStudentCourse.Pair(a51, s38, c8);
            AssignmentStudentCourse.Pair(a52, s38, c8);
            AssignmentStudentCourse.Pair(a53, s38, c8);
            AssignmentStudentCourse.Pair(a54, s38, c8);
            AssignmentStudentCourse.Pair(a55, s38, c8);
            AssignmentStudentCourse.Pair(a56, s38, c8);

            AssignmentStudentCourse.Pair(a50, s39, c8);
            AssignmentStudentCourse.Pair(a51, s39, c8);
            AssignmentStudentCourse.Pair(a52, s39, c8);
            AssignmentStudentCourse.Pair(a53, s39, c8);
            AssignmentStudentCourse.Pair(a54, s39, c8);
            AssignmentStudentCourse.Pair(a55, s39, c8);
            AssignmentStudentCourse.Pair(a56, s39, c8);

            AssignmentStudentCourse.Pair(a50, s40, c8);
            AssignmentStudentCourse.Pair(a51, s40, c8);
            AssignmentStudentCourse.Pair(a52, s40, c8);
            AssignmentStudentCourse.Pair(a53, s40, c8);
            AssignmentStudentCourse.Pair(a54, s40, c8);
            AssignmentStudentCourse.Pair(a55, s40, c8);
            AssignmentStudentCourse.Pair(a56, s40, c8);

            #endregion

            #endregion

            #endregion

            #region Populate Data

            Students = new List<Student>() { s1, s2, s3, s4, s5, s6, s7, s8, s8, s10, s11, s12, s13, s14, s15, s16, s17, s18, s19, s20, s21, s22, s23, s24, s25, s26, s27, s28, s29, s30, s31, s32, s33, s34, s35, s36, s37, s38, s39, s40 };
            Trainers = new List<Trainer>() { t1, t2, t3, t4, t5, t6, t7, t8 };
            Courses = new List<Course>() { c1, c2, c3, c4, c5, c6, c7, c8 };
            Assignments = new List<Assignment>() { a1, a2, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16, a17, a18, a19, a20, a21, a22, a23, a24, a25, a26, a27, a28, a29, a30, a31, a32, a33, a34, a35, a36, a37, a38, a39, a40, a41, a42, a43, a44, a45, a46, a47, a48, a49, a51, a52, a53, a54, a55, a56 };

            #endregion

        }
    }
}
