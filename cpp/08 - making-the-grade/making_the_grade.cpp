#include <array>
#include <string>
#include <vector>

// Round down all provided student scores.
std::vector<int> round_down_scores(std::vector<double> student_scores) {
    std::vector<int> rounded_scores {};
    for (int i = 0; i < student_scores.size(); i++) {
        rounded_scores.emplace_back(static_cast<int>(student_scores[i]));
    }
    return rounded_scores;
}


// Count the number of failing students out of the group provided.
int count_failed_students(std::vector<int> student_scores) {
    int non_passing_grade_count = 0;
    for (int i = 0; i < student_scores.size(); i++) {
        if (student_scores[i] <= 40) {
            non_passing_grade_count += 1;
        }
    }
    return non_passing_grade_count;
}

// Determine how many of the provided student scores were 'the best' based on the provided threshold.
std::vector<int> above_threshold(std::vector<int> student_scores, int threshold) {
    std::vector<int> top_grades {};
    for (int i = 0; i < student_scores.size(); i++) {
        if (student_scores[i] >= threshold) {
            top_grades.emplace_back(student_scores[i]);
        }
    }
    return top_grades;
}

// Create a list of grade thresholds based on the provided highest grade.
std::array<int, 4> letter_grades(int highest_score) {
    int difference = highest_score - 40;
    int section = difference / 4;
    int D = 40 + 1;
    int C = D + section;
    int B = C + section;
    int A = B + section;
    
    return std::array<int, 4> {D, C, B, A};
}


// Organize the student's rank, name, and grade information in ascending order.
std::vector<std::string> student_ranking(std::vector<int> student_scores, std::vector<std::string> student_names) {
    std::vector<std::string> matched_scores = {};
    for (int i = 0; i < student_scores.size(); i++) {
        matched_scores.emplace_back(std::to_string(i+1) + ". " + student_names[i] + ": " + std::to_string(student_scores[i]));
    }
    return matched_scores;
}

// Create a string that contains the name of the first student to make a perfect score on the exam.
std::string perfect_score(std::vector<int> student_scores, std::vector<std::string> student_names) {
    for (int i = 0; i < student_scores.size(); i++) {
        if (student_scores[i] == 100) {
            return student_names[i];
        }
    }
    return "";
}
