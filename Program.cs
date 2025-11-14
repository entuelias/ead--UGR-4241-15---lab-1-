var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddSingleton<TodoRepository>();

var app = builder.Build();

// GET all
app.MapGet("/todoitems", (TodoRepository repo) =>
{
    return repo.GetAll();
});

// GET by id
app.MapGet("/todoitems/{id}", (TodoRepository repo, int id) =>
{
    var item = repo.Get(id);
    return item is not null ? Results.Ok(item) : Results.NotFound();
});

// POST (create)
app.MapPost("/todoitems", (TodoRepository repo, TodoItem item) =>
{
    var created = repo.Add(item);
    return Results.Created($"/todoitems/{created.Id}", created);
});

// PUT (update)
app.MapPut("/todoitems/{id}", (TodoRepository repo, int id, TodoItem updated) =>
{
    var success = repo.Update(id, updated);
    return success ? Results.NoContent() : Results.NotFound();
});

// DELETE
app.MapDelete("/todoitems/{id}", (TodoRepository repo, int id) =>
{
    var success = repo.Delete(id);
    return success ? Results.NoContent() : Results.NotFound();
});

app.Run();
