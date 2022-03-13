import React from "react";
import {useState} from "react";
import Header from './Header';
import Footer from "./Footer";

interface Props{
    title:string,
    text:string
}

export default function App({title,text}:Props){


    const[count,setCount] = useState(0);

    return(

        <div>
            <Header title = {title}></Header>
            <h1>{title}</h1>
            <div>
                {text}
            </div>
        

        <div>
            Count {count}
        </div>

        <button onClick={() => setCount(count + 1)}>
            Click
        </button>
        <Footer title={title}>
            <p>This is my website 2022</p>
        </Footer>

        </div>
    );
}