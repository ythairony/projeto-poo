﻿using System;

class Program { 
    public static void Main() {
        Provider p = new Provider(1, "Jhon", "Winston", "JW Clear Houses", "email@email.com", "Male", "New Jersey");
        Category c = new Category(1, "House Clear");

        Console.WriteLine(p);

    }
}
