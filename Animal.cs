abstract class Animal{
    public abstract void nacer();
    public abstract void caminar();
    public abstract void crecer();
    public abstract void morir();
    public abstract void comer();
    public void vivir(){
        nacer();
        caminar();
        comer();
        crecer();
        caminar();
        morir();
    }
}