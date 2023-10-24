def classify(number):
    """ A perfect number equals the sum of its positive divisors.

    :param number: int a positive integer
    :return: str the classification of the input integer
    """
    if number <= 0:
        raise ValueError("Classification is only possible for positive integers.")
    
    total = 0

    for factor in range(1,number):
        if number % factor == 0:
            total += factor

    if number == total:
        return "perfect"

    if number < total:
        return "abundant"

    if number > total:
        return "deficient"
