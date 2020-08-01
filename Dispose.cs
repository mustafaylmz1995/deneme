using System;

public class Person: IDisposable{

    #region IDisposable Support
    private bool disposedValue = false; 
    protected virtual void Dispose(bool disposing){
        if (!disposedValue){
            if(disposing){
                
            }
            disposedValue = true;
        }
    }

    public void Dispose(){
        Dispose(true);
    }
    #endregion
}