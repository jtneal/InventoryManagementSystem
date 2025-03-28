﻿namespace JasonNealC968.Models
{
    public abstract class Part
    {
        public int PartID { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        public string Category { get; set; } = string.Empty;
    }
}
