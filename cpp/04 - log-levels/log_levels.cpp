#include <string>

namespace log_line {

    std::string message(std::string inputlog) {
        return inputlog.substr(inputlog.find(" ")+1);
    }

    std::string log_level(std::string inputlog) {
        return inputlog.substr(1,inputlog.find("]")-1);
    }

    std::string reformat(std::string inputlog) {
        return message(inputlog) + " (" + log_level(inputlog) + ")";
    }

} // namespace log_line
