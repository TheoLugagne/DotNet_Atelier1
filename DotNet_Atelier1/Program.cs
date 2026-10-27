
using DotNet_Atelier1;

Console.WriteLine("Hello, World!");
string map = """
+--+--------+
|  /        |
|  +--+--+  |
|     |k    |
+--+  |  +--+
+  |k       |
|  +-------/|
|           |
+-----------+
""";
Labyrinth labyrinth = new Labyrinth(map);
labyrinth.Display();