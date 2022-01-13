void CreateTurnQueue() {
    // This line finds all objects that has "Creature" tag on them and puts in a GameObject List
    creatures = new.List<GameObject>(GameObject.FindGameObjectsWithTag("Creature")); 
    
    bool continueCycle = true; // used for stopping the sorting loop
    
    for(int i = -5; continueCycle; i++) { // i value is minimum value to start, in this game minimum modifier is -5
    
        bool continueCycle = false;
        foreach(var creature in creatures) {
            
            if(creature.GetComponent<CharacterControls>().agiMod > i) { // My sorting value is creature's agility Modifier value
                
                int currentIndex = creatures.IndexOf(creature);
                
                if(currentIndex < 0) {
                    creatures.RemoveAt(currentIndex);
                    creatures.Insert(0, creature);
                }
                
                continueCycle = true;
            }
        }
    }
}