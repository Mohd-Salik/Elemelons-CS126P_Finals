# CS126P_Finals
Unity, 2D, single player, side scroller, pixel art

V0.0.1 - Initialize Game World
-Added platform
-Added character controller (movement, jump and crouch)

V0.0.2 - Basic Movement
-Revised character controller
-Added plantmechanic script
-Added Farmer walking and running animation

V0.1.0 - Base Game
-Revised enemy spawn
-Added Switching from farmer to warrior
-Reworked GUI implementation (separate camera)

V0.3.0 - Environment and Enemy Update
-Day and Night Cycle of environment
-Added timer to end the day/night
-Dynamic Transparency of background during the cycle
-Enemies will now only spawn at night
-Enemies will die in the morning

V0.4.0 - Planting Mechanic
-Till soil enhanced (jump 5 times to till)
-Player can select element type
-Added element counter to GUI
-Player can now plant on tilled soil
-Planting will decrement element seed counter
-Player can now harvest plants
-Harvesting will increment element power counter

V0.4.1 - Planting Bug Fix Patch
-Fixed plant will ragdoll beyond the map
-Fixed null instantiate on planting when no element is selected
