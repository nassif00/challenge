using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace ClimateMonitor.Services.Models;

public class DeviceReadingRequest
{
    [Required]
    [RegularExpression(@"^(0|[1-9]\d*)\.(0|[1-9]\d*)\.(0|[1-9]\d*)(?:-((?:0|[1-9]\d*|\d*[a-zA-Z-][0-9a-zA-Z-
]*)(?:\.(?:0|[1-9]\d*|\d*[a-zA-Z-][0-9a-zA-Z-]*))*))?(?:\+([0-9a-zA-Z-]+(?:\.[0-9azA-Z-]+)*))?$",
        ErrorMessage = "The firmware value does not match semantic versioning format.")]
    public string FirmwareVersion { get; set; } = string.Empty;

    [Required]
    public decimal Temperature { get; set; }

    [Required]
    public decimal Humidity { get; set; }
}
