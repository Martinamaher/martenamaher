class RecentOrder {
  final int orderId;
  final String customerName;
  final DateTime orderDate;
  final double orderTotal;
  final double weight;  // الوزن المضاف

  RecentOrder({
    required this.orderId,
    required this.customerName,
    required this.orderDate,
    required this.orderTotal,
    required this.weight,
  });

  factory RecentOrder.fromJson(Map<String, dynamic> json) {
    return RecentOrder(
      orderId: json['orderId'],
      customerName: json['customerName'],
      orderDate: DateTime.parse(json['orderDate']),
      orderTotal: (json['orderTotal'] as num).toDouble(),
      weight: (json['weight'] as num).toDouble(),
    );
  }
}

class DashboardData {
  final int totalUsers;
  final int totalOrders;
  final int totalProducts;
  final double totalRevenue;
  final List<RecentOrder> recentOrders;
  final String topProductName;
  final int topProductSales;

  DashboardData({
    required this.totalUsers,
    required this.totalOrders,
    required this.totalProducts,
    required this.totalRevenue,
    required this.recentOrders,
    required this.topProductName,
    required this.topProductSales,
  });

  factory DashboardData.fromJson(Map<String, dynamic> json) {
    var list = json['recentOrders'] as List;
    List<RecentOrder> ordersList = list.map((i) => RecentOrder.fromJson(i)).toList();

    return DashboardData(
      totalUsers: json['totalUsers'],
      totalOrders: json['totalOrders'],
      totalProducts: json['totalProducts'],
      totalRevenue: (json['totalRevenue'] as num).toDouble(),
      recentOrders: ordersList,
      topProductName: json['topProductName'],
      topProductSales: json['topProductSales'],
    );
  }
}