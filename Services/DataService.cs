public class DataService
{
    public string Company{get;}= "Mitchell & Fabrication";
    
    public record Service(string Title, string Description, List<string> Buttons);

    public List<Service> Services { get; } = new()
    {
        new("Print & Signage", "Large-format 24\" roll printing for banners, vehicle graphics, and retail displays. Standard 11×18 for menus, flyers, posters, and marketing collateral.",
            new List<string> {"Banners", "Menu","Flyers", "Window Graphic", "Signs"}),    

        new("Laser Engraving", "12×18 precision engraving and cutting on wood, acrylic, leather, and coated metals. Custom gifts, awards, branded merchandise, and decorative signage.",
            new List<string> {"Custom Gifts", "Awards", "Branded Merch", "Acrylic Signs"}),
   
        new("3D Printing", "Rapid prototyping, custom parts, replacement components, product mockups, and short-run consumer items. Fast turnaround on single units or small batches.",
            new List<string> {"Prototypes", "Custom Parts", "Replacement Part", "Mockups"}),

        new("Carpentry & Woodwork", "Custom furniture, built-in shelving, cabinetry, and finish carpentry for residential and commercial spaces. Quality materials and clean joinery throughout.",
            new List<string> {"Arcade Cabinets"}),

        new("Event Production","Full-service fabrication and print packages for weddings, corporate events, grand openings, and galas. Custom backdrops, signage suites, engraved favors, branded décor — all from one vendor.",
            new List<string> {"Weddings", "Corporate Events" , "Grand Openings" , "Custom Décor"})
    };

    public Dictionary<string,string> MyInfo {get;} = new ()
    {
        {"phone","410-877-7260"},
        {"email", "duane.a.mitchell@outlook.com"},
        {"location", "Conyers, GA"}

    };
}
