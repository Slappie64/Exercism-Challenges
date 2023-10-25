def is_isogram(string):
    string = string.replace(" ", "")
    string = string.replace("-", "")
    return len(set(string.lower())) == len(string.lower())
