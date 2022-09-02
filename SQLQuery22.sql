create table CarImage (
ImageId int primary key not null IDENTITY (1,1),
CarId int,
ImagePath nvarchar(1000),
ImageData Datetime)
