using JasonNealC968.Constants;
using JasonNealC968.DAL;
using JasonNealC968.Models;
using System.ComponentModel;

namespace JasonNealC968.Mappers
{
    public static class PartMapper
    {
        public static PartEntity HydratePartEntity(PartEntity partEntity, Part part)
        {
            partEntity.Name = part.Name;
            partEntity.Price = part.Price;
            partEntity.InStock = part.InStock;
            partEntity.Min = part.Min;
            partEntity.Max = part.Max;

            if (part is Outsourced outsourced)
            {
                partEntity.Category = PartCategory.Outsourced;
                partEntity.CompanyName = outsourced.CompanyName;
                partEntity.MachineID = null;

            }
            else if (part is Inhouse inhouse)
            {
                partEntity.Category = PartCategory.InHouse;
                partEntity.MachineID = inhouse.MachineID;
                partEntity.CompanyName = null;
            }

            return partEntity;
        }

        public static PartEntity ToPartEntity(Part part)
        {
            var partEntity = new PartEntity()
            {
                PartID = part.PartID,
                Name = part.Name,
                Price = part.Price,
                InStock = part.InStock,
                Min = part.Min,
                Max = part.Max,
                Category = string.Empty,
            };

            if (part is Outsourced outsourced)
            {
                partEntity.Category = PartCategory.Outsourced;
                partEntity.CompanyName = outsourced.CompanyName;
            }
            else if (part is Inhouse inhouse)
            {
                partEntity.Category = PartCategory.InHouse;
                partEntity.MachineID = inhouse.MachineID;
            }

            return partEntity;
        }

        public static BindingList<Part> ToPartModels(BindingList<PartEntity> partEntities)
        {
            var parts = new BindingList<Part>();

            foreach (var part in partEntities)
                parts.Add(ToPartModel(part));

            return parts;
        }

        public static Part ToPartModel(PartEntity partEntity)
        {
            Part part = partEntity.Category == PartCategory.Outsourced
                ? new Outsourced() { CompanyName = partEntity.CompanyName! }
                : new Inhouse() { MachineID = (int)partEntity.MachineID! };

            part.PartID = partEntity.PartID;
            part.Name = partEntity.Name;
            part.InStock = partEntity.InStock;
            part.Price = partEntity.Price;
            part.Min = partEntity.Min;
            part.Max = partEntity.Max;
            part.Category = partEntity.Category;

            return part;
        }
    }
}
