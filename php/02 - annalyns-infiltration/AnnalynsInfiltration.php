<?php

class AnnalynsInfiltration
{
    public function canFastAttack($is_knight_awake)
    {
        /* Check whether Fast Attack is possible.

        :param $is_knight_awake: bool - True or False whether Knight is awake.
        :return bool: True or False whether Fast Attack is possible.

        */

        return !$is_knight_awake;
    }

    public function canSpy(
        $is_knight_awake,
        $is_archer_awake,
        $is_prisoner_awake
    ) {
        /* Check whether Spying is possible.

        :param $is_knight_awake: bool - True or False whether Knight is awake.
        :param $is_archer_awake: bool - True or False whether Archer is awake.
        :param $is_prisoner_awake: bool - True or False whether Prisoner is awake.
        :return bool: True or False whether Spying is possible.

        */

        return $is_archer_awake || $is_knight_awake || $is_prisoner_awake;
    }

    public function canSignal(
        $is_archer_awake,
        $is_prisoner_awake
    ) {
        /* Check whether Signalling is possible.

        :param $is_archer_awake: bool - True or False whether Archer is awake.
        :param $is_prisoner_awake: bool - True or False whether Prisoner is awake.
        :return bool: True or False whether Signalling is possible.

        */

        return !$is_archer_awake && $is_prisoner_awake;
    }

    public function canLiberate(
        $is_knight_awake,
        $is_archer_awake,
        $is_prisoner_awake,
        $is_dog_present
    ) {
        /* Check whether freeing the prisoner is possible.

        :param $is_knight_awake: bool - True or False whether Knight is awake.
        :param $is_archer_awake: bool - True or False whether Archer is awake.
        :param $is_prisoner_awake: bool - True or False whether Prisoner is awake.
        :param $is_dog_present: bool - True or False whether Dog is present.
        :return bool: True or False whether freeing the prisoner is possible.

        */

        return ($is_dog_present && !$is_archer_awake) || (!$is_archer_awake && !$is_knight_awake && $is_prisoner_awake);
    }
}
