create database Fundoo;

use Fundoo

CREATE TABLE [dbo].[userSignup](
	[userId] [int] IDENTITY(1,1) NOT NULL,
	[fname] [varchar](20) NOT NULL,
	[lname] [varchar](20) NOT NULL,
	[phno] [int] NULL,
	[address] [varchar](50) NULL,
	[email] [varchar](50) NOT NULL,
	[password] [varchar](100) NOT NULL,
	[cpassword] [varchar](100) NOT NULL,
	[registeredDate] [datetime] NULL,
	[modifiedDate] [datetime] NULL,
	
PRIMARY KEY CLUSTERED 
(
	[userId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO