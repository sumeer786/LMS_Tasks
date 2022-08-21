package CR9;

public class ProductSystem {
    public static void main(String[] args){
        ProductComponent produce = new ProductGroup("Produce");
        ProductComponent cereal = new ProductGroup("Cereal");
        ProductComponent everyProduct = new ProductGroup("All Products\n");

        everyProduct.add(produce);
        everyProduct.add(cereal);

        produce.add(new Product("Tomato", 1.99));
        produce.add(new Product("Orange", .99));
        produce.add(new Product("Potato", .35));

        cereal.add(new Product("Special K", 4.79));
        cereal.add(new Product("Cheerios", 3.68));
        cereal.add(new Product("Raisin Bran", 3.68));

        everyProduct.displayProductInfo();
    }
}