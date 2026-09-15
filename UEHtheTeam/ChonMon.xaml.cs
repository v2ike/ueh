using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Maui.Controls;
using UEHtheTeam.Models;
using UEHtheTeam.Services;

namespace UEHtheTeam;

public partial class ChonMon : ContentPage
{
    private readonly ApiService _apiService = new ApiService();
    private List<Course> _allCourses = new List<Course>();

    public ChonMon()
    {
        InitializeComponent();
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();

        try
        {
            // 1. Tải danh sách môn học từ API
            var courses = await _apiService.GetCoursesAsync();

            if (courses != null && courses.Count > 0)
            {
                _allCourses = courses;
            }
            else
            {
                _allCourses = GetSampleData();
            }
        }
        catch (Exception ex)
        {
            System.Diagnostics.Debug.WriteLine($"Lỗi API: {ex.Message}");
            _allCourses = GetSampleData();
        }

        // 2. Gán dữ liệu lên CollectionView và cập nhật số lượng đếm ban đầu
        CoursesCollectionView.ItemsSource = _allCourses;
        UpdateSelectedCount();
    }

    // Kích hoạt mỗi khi tích chọn / bỏ chọn checkbox bất kỳ
    private void OnCourseCheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        UpdateSelectedCount();
    }

    // Đếm và hiển thị số lượng môn đã chọn lên Label 'somon'
    private void UpdateSelectedCount()
    {
        int count = _allCourses.Count(c => c.IsSelected);
        somon.Text = $"Đã chọn {count} môn";
    }

    // Dữ liệu fallback trong trường hợp API/Database chưa có sẵn
    private List<Course> GetSampleData()
    {
        return new List<Course>
        {
            new Course
            {
                CourseName = "Lập trình Di động (.NET)",
                CourseCode = "BIT503001",
                Credits = "4 TC",
                CourseType = "Dự án môn học",
                TagBgColor = "#E6F4EA",
                TagTextColor = "#137333",
                IsSelected = true
            },
            new Course
            {
                CourseName = "Kinh tế vĩ mô",
                CourseCode = "ECO501001",
                Credits = "3 TC",
                CourseType = "BTL / Tiểu luận",
                TagBgColor = "#FEF3C7",
                TagTextColor = "#D97706",
                IsSelected = false
            },
            new Course
            {
                CourseName = "Phương pháp Nghiên cứu Kinh tế",
                CourseCode = "RES502002",
                Credits = "3 TC",
                CourseType = "Đề án NCKH",
                TagBgColor = "#E6F4EA",
                TagTextColor = "#137333",
                IsSelected = false
            }
        };
    }
}