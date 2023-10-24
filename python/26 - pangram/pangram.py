def is_pangram(sentence):
    """ Check whether a sentence contains all the letters of the alphabet.

    :param sentence: string - String to test against.
    :return: bool - Whether sentence contains all the letters.
    
    """
    alphabet = set("abcdefghijklmnopqrstuvwxyz")

    return set(sentence.lower()) >= alphabet
