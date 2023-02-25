using System;
using System.Collections.Generic;


// LeHoangKhoi- 20mc-20it438

//xây dựng interface IBook mô tả title, author, publisher, year,isbm,..
internal class IBook
    {
        string Title { get; set; }
        string Author { get; set; }
        string Publisher { get; set; }
        int Year { get; set; }
        string ISBN { get; set; }
        List<string> Chapters { get; set; }
    }



