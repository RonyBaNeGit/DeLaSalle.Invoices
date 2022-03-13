import React from "react";


interface Props{
    title:string,
    
}

export default function Header({title}:Props){



    return(

        <React.Fragment>
            <h1>{title}</h1>
           

        </React.Fragment>
    );
}