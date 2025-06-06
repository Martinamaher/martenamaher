import 'dart:convert';
import 'package:http/http.dart' as http;
import '../models/dashboard_model.dart';

class DashboardService {
  final String apiUrl = 'https://yourapi.com/api/dashboard/summary'; // رابط API الخاص بك

  Future<DashboardData> fetchDashboardData(String token) async {
    final response = await http.get(
      Uri.parse(apiUrl),
      headers: {
        'Authorization': 'Bearer $token',
        'Content-Type': 'application/json',
      },
    );

    if (response.statusCode == 200) {
      return DashboardData.fromJson(jsonDecode(response.body));
    } else {
      throw Exception('Failed to load dashboard data');
    }
  }
}