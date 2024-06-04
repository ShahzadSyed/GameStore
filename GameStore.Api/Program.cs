using GameStore.Api.Dtos;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

List<GameDto> games = [
    new(
        1,
        "Street Fighter",
        "Fighting",
        19.9M,
        new DateOnly(2024 , 05 , 29)),
    new(
        2,
        "Final fantasy",
        "Roleplaying",
        18.9M,
        new DateOnly(2024 , 05 , 29)),
    new(
        3,
        "FiFA 2024",
        "Sports",
        20.9M,
        new DateOnly(2024 , 05 , 29)),
];

// /get/games
app.MapGet("game", () => games);

// Get /games/1
app.MapGet("game/{id}", (int id) => games.Find(game => game.Id ==  id));



app.Run();
