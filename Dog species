class Animal {
    String speciesName;
 
    public Animal(String speciesName) {
        this.speciesName = speciesName;
    }
}
 
class Mammal extends Animal {
    boolean hasFur;
 
    public Mammal(String speciesName, boolean hasFur) {
        super(speciesName);
        this.hasFur = hasFur;
    }
}
 
class Dog extends Mammal {
    String breed;
 
    public Dog(String speciesName, boolean hasFur, String breed) {
        super(speciesName, hasFur);
        this.breed = breed;
    }
}
 
public class DogSpecias{
    public static void main(String[] args) {
        Dog dog = new Dog("Canis lupus familiaris", true, "Golden Retriever");
 
        System.out.println("Species Name: " + dog.speciesName);
        System.out.println("Has Fur: " + dog.hasFur);
        System.out.println("Breed: " + dog.breed);
    }
}

