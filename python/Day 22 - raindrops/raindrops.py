def convert(number):

    pling_plang_plong = ""

    if number % 3 == 0:
        pling_plang_plong += "Pling"

    if number % 5 == 0:
        pling_plang_plong += "Plang"

    if number % 7 == 0:
        pling_plang_plong += "Plong"

    if pling_plang_plong == "":
        return str(number)
    
    return pling_plang_plong