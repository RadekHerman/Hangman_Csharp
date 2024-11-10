using System.Collections.Generic;

namespace Hangman_Csharp
{
    class Drawing
    {
        public static Dictionary<int, string> wisielec = new Dictionary<int, string>(){
        {7,@"
            +==========
            ||        
            ||       
            ||      
            ||    
            ||         
            ||       
            ||
            TTTTTTTTTTTTT
            "},
        {6,@"
            +==========
            ||      |  
            ||       
            ||      
            ||    
            ||         
            ||       
            ||
            TTTTTTTTTTTTT
            "},

        {5,@"
            +==========
            ||      |  
            ||     (oo)  
            ||     
            ||     
            ||        
            ||       
            ||
            TTTTTTTTTTTTT
            "},
        {4,@"
            +==========
            ||      |  
            ||     (oo)  
            ||      &
            ||     
            ||        
            ||      
            ||
            TTTTTTTTTTTTT
            "},
        {3,@"
            +==========
            ||      |  
            ||     (oo)  
            ||      &
            ||     (())  
            ||      
            ||       
            ||
            TTTTTTTTTTTTT
            "},
        {2,@"
            +==========
            ||      |  
            ||     (oo)  
            ||      &
            ||   +-(())-+   
            ||     
            ||
            ||
            TTTTTTTTTTTTT
            "},
        {1,@"
            +==========
            ||      |  
            ||     (oo)  
            ||      &
            ||   +-(())-+   
            ||      V   
            ||      
            ||
            TTTTTTTTTTTTT
            "},
        {0,@"
                +==========
                ||      |  
                ||     (oo)  
                ||      &
                ||   +-(())-+   
                ||      V   
                ||      JL  
                ||
                TTTTTTTTTTTTT
                "},
        };
    }
}
