use SQL_PRACTICE

alter table zipcode_info
add state varchar(2);

EXEC sp_rename 
    'zipcode_info.state',
    'STATE',
    'COLUMN';

select* from zipcode_info


alter table instructor_info
add STREET_ADDRESS varchar(50),ZIP_CODE varchar(5)

select* from instructor_info



alter table student_info
add STREET_ADDRESS varchar(50),ZIP_CODE varchar(5)

select* from student_info


alter table section_info
add LOCATION varchar(50),CAPACITY numeric(3,0)

select* from section_info


alter table enrollment_info
add ENROLLMENT_DATE date

select* from enrollment_info


alter table grade_info
add NUMERIC_GRADE numeric(3,0)

select* from grade_info



