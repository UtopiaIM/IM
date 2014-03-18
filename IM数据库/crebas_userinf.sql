/*==============================================================*/
/* DBMS name:      MySQL 5.0                                    */
/* Created on:     2014/3/17 17:25:54                           */
/*==============================================================*/


drop table if exists Attendance;

drop table if exists Classroom;

drop table if exists Course;

drop table if exists FriendGroup;

drop table if exists FriendRelationship;

drop table if exists SelectCourse;

drop table if exists Sharing;

drop table if exists TeachingTime;

drop table if exists User;

/*==============================================================*/
/* Table: Attendance                                            */
/*==============================================================*/
create table Attendance
(
   AtteID               int not null,
   UserID               int not null,
   TeacID               int not null,
   AtteStatus           int,
   primary key (AtteID)
);

/*==============================================================*/
/* Table: Classroom                                             */
/*==============================================================*/
create table Classroom
(
   ClasID               int not null,
   UserID               int not null,
   CourID               int not null,
   ClasNum              int not null,
   ClasName             varchar(20) not null,
   ClasInfo             varchar(200),
   ClasBeginDate        date,
   ClasEndDate          date,
   primary key (ClasID)
);

/*==============================================================*/
/* Table: Course                                                */
/*==============================================================*/
create table Course
(
   CourID               int not null,
   CourNum              int,
   primary key (CourID)
);

/*==============================================================*/
/* Table: FriendGroup                                           */
/*==============================================================*/
create table FriendGroup
(
   GrouID               int not null,
   UserID               int not null,
   GrouName             varchar(20),
   primary key (GrouID)
);

/*==============================================================*/
/* Table: FriendRelationship                                    */
/*==============================================================*/
create table FriendRelationship
(
   RelaID               int not null,
   UserID               int not null,
   GrouID               int not null,
   Use_UserID           int not null,
   primary key (RelaID)
);

/*==============================================================*/
/* Table: SelectCourse                                          */
/*==============================================================*/
create table SelectCourse
(
   SecoID               int not null,
   UserID               int not null,
   ClasID               int not null,
   primary key (SecoID)
);

/*==============================================================*/
/* Table: Sharing                                               */
/*==============================================================*/
create table Sharing
(
   SharID               int not null,
   ClasID               int not null,
   UserID               int not null,
   SharUrl              varchar(100),
   SharTime             datetime,
   SharInfo             text,
   primary key (SharID)
);

/*==============================================================*/
/* Table: TeachingTime                                          */
/*==============================================================*/
create table TeachingTime
(
   TeacID               int not null,
   ClasID               int not null,
   TeacDate             date not null,
   TeacBeginTime        time not null,
   TeacEndTime          time not null,
   primary key (TeacID)
);

/*==============================================================*/
/* Table: User                                                  */
/*==============================================================*/
create table User
(
   UserID               int not null,
   UserAccount          varchar(15) not null,
   UserPassword         varchar(20) not null,
   UserEmail            varchar(40),
   UserPhone            int,
   UserGender           int,
   UserBirthDate        date,
   UserSorT             int not null,
   UserNickName         varchar(20) not null,
   UserPersonalMessage  varchar(200),
   UserIMNum            int not null,
   primary key (UserID)
);

alter table Attendance add constraint FK_FK_Attendance_User foreign key (UserID)
      references User (UserID) on delete restrict on update restrict;

alter table Attendance add constraint FK_FK_TeachingTime_Attendance foreign key (TeacID)
      references TeachingTime (TeacID) on delete restrict on update restrict;

alter table Classroom add constraint FK_FK_Course_Classroom foreign key (CourID)
      references Course (CourID) on delete restrict on update restrict;

alter table Classroom add constraint FK_FK_User_Classroom foreign key (UserID)
      references User (UserID) on delete restrict on update restrict;

alter table FriendGroup add constraint FK_FK_Group_User foreign key (UserID)
      references User (UserID) on delete restrict on update restrict;

alter table FriendRelationship add constraint FK_FK_Group_FriendRelationship foreign key (GrouID)
      references FriendGroup (GrouID) on delete restrict on update restrict;

alter table FriendRelationship add constraint FK_FK_User1_FriendRelationship foreign key (UserID)
      references User (UserID) on delete restrict on update restrict;

alter table FriendRelationship add constraint FK_FK_User2_FriendRelationship foreign key (Use_UserID)
      references User (UserID) on delete restrict on update restrict;

alter table SelectCourse add constraint FK_FK_Classroom_SelectCourse foreign key (ClasID)
      references Classroom (ClasID) on delete restrict on update restrict;

alter table SelectCourse add constraint FK_FK_User_SelectCourse foreign key (UserID)
      references User (UserID) on delete restrict on update restrict;

alter table Sharing add constraint FK_FK_Classroom_Sharing foreign key (ClasID)
      references Classroom (ClasID) on delete restrict on update restrict;

alter table Sharing add constraint FK_FK_User_Sharing foreign key (UserID)
      references User (UserID) on delete restrict on update restrict;

alter table TeachingTime add constraint FK_FK_Classroom_TeachingTime foreign key (ClasID)
      references Classroom (ClasID) on delete restrict on update restrict;

