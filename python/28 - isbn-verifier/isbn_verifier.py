def is_valid(isbn):
    isbn = isbn.replace("-", "")

    if len(isbn) != 10:
        return False
    
    validation = 0
    for (i, digit) in enumerate(isbn):
        if digit.isdigit():
            validation += int(digit) * (10 - i)
        elif i == 9 and digit == "X":
            validation += 10
        else:
            return False
    
    return validation % 11 == 0