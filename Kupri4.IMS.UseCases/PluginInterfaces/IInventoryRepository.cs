﻿using Kupri4.IMS.CoreBusiness;

namespace Kupri4.IMS.UseCases.PluginInterfaces;

public interface IInventoryRepository
{
    Task<IEnumerable<Inventory>> GetInventoriesByNameAsync(string name);
    Task AddInventoryAsync(Inventory inventory);
    Task UpdateInventoryAsync(Inventory inventory);
    Task<Inventory> GetInventoryAsync(Guid id);
}
