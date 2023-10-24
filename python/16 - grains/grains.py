def square(number):
    """ Calculate the grains on any given square.

    :param number: int - Number of square on the chess board.
    :return: int - Number of grains on that square.
    """

    total_grains = 1
    squares = 1
    if number <= 0 or number > 64:
        raise ValueError('square must be between 1 and 64')
    
    while squares < number:
        total_grains *= 2
        squares += 1

    return total_grains


def total():
    """ Calculate the total number of grains of wheat on a chessboard.

    :return: int - Total number of grains on the total board.
    """

    total_grains = 0
    for squares in range(64):
        total_grains += square(squares+1)
    
    return total_grains
