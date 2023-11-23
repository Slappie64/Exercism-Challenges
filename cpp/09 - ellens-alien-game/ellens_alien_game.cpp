namespace targets {
    
    class Alien {
        public:
            Alien(int x_coord, int y_coord) {
                x_coordinate = x_coord;
                y_coordinate = y_coord;
            }

            int get_health() {
                return health;
            }

            bool hit() {
                health -= 1;
                return true;
            }

            bool is_alive() {
                if (health <= 0) {
                    return false;
                }
                else {
                    return true;
                }
            }

            bool teleport(int x_coord, int y_coord) {
                x_coordinate = x_coord;
                y_coordinate = y_coord;
                return true;
            }

            bool collision_detection(Alien other_alien) {
                if (x_coordinate == other_alien.x_coordinate && y_coordinate == other_alien.y_coordinate) {
                    return true;
                }
                else {
                    return false;
                }
            }

            int x_coordinate = 0;
            int y_coordinate = 0;

        private:
            
            int health = 3;
    };

}  // namespace targets