var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/{num1}/{num2}", (int num1, int num2) => AddTwoNums(num1, num2));

app.Run();

int AddTwoNums(int num1, int num2) {
    return num1 + num2;
}