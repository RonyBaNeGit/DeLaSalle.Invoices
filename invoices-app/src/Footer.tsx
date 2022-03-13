import React from "react";


interface Props{
    title:string,
    children?:JSX.Element
    
}

export default function Footer({title,children}:Props){



    return(

        <React.Fragment>
            <p>{title}</p>

            {children}
           

        </React.Fragment>
    );
}