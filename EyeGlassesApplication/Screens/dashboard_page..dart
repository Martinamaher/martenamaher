import 'package:flutter/material.dart';
import '../models/dashboard_model.dart';
import '../services/api_service.dart';

class DashboardPage extends StatefulWidget {
  final String token;
  DashboardPage({required this.token});

  @override
  _DashboardPageState createState() => _DashboardPageState();
}

class _DashboardPageState extends State<DashboardPage> {
  late Future<DashboardData> futureDashboardData;

  @override
  void initState() {
    super.initState();
    futureDashboardData = DashboardService().fetchDashboardData(widget.token);
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(title: Text('Dashboard')),
      body: FutureBuilder<DashboardData>(
        future: futureDashboardData,
        builder: (context, snapshot) {
          if (snapshot.hasData) {
            var data = snapshot.data!;
            return ListView(
              padding: EdgeInsets.all(16),
              children: [
                Text('Total Users: ${data.totalUsers}'),
                Text('Total Orders: ${data.totalOrders}'),
                Text('Total Products: ${data.totalProducts}'),
                Text('Total Revenue: \$${data.totalRevenue.toStringAsFixed(2)}'),
                SizedBox(height: 20),
                Text('Top Product: ${data.topProductName} (Sales: ${data.topProductSales})'),
                SizedBox(height: 20),
                Text('Recent Orders:', style: TextStyle(fontWeight: FontWeight.bold)),
                ...data.recentOrders.map((order) => ListTile(
                      title: Text('${order.customerName}'),
                      subtitle: Text('Date: ${order.orderDate.toLocal().toString().split(' ')[0]}'),
                      trailing: Column(
                        crossAxisAlignment: CrossAxisAlignment.end,
                        children: [
                          Text('Total: \$${order.orderTotal.toStringAsFixed(2)}'),
                          Text('Weight: ${order.weight.toStringAsFixed(2)} kg'),
                        ],
                      ),
                    )),
              ],
            );
          } else if (snapshot.hasError) {
            return Center(child: Text('Error: ${snapshot.error}'));
          }
          return Center(child: CircularProgressIndicator());
        },
      ),
    );
  }
}
