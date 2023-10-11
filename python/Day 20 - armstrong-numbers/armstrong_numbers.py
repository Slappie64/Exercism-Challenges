def is_armstrong_number(number):
    """ Determine whether a given number is an Armstrong Number

    :param number: int - Given number to check whether this is an Armstrong Number
    :return: bool - True or False depending on total equals number
    
    """

    total = 0
    for num in str(number):
        total += int(num)**len(str(number))

    return total == number
