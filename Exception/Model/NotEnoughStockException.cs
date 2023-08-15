using System;
namespace Exception.Model
{
	public class NotEnoughStockException:System.Exception
	{
		int _productId;
		int _currentStock;
		int _unitsRequested;
		public NotEnoughStockException(string message,int productId,int currentStock,int unitsRequested)
			:base(message)
{
			_productId = productId;
			_currentStock = currentStock;
			_unitsRequested = unitsRequested;

		}

		public int ProductId => _productId;
		public int CurrentStock => _currentStock;
		public int UnitsRequested => _unitsRequested;
	}
}

