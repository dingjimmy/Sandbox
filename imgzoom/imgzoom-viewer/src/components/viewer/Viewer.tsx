import React, { useEffect, useState } from 'react';
import OpenSeadragon from 'openseadragon';
import { v4 as uuidv4 } from 'uuid';
import { ViewerProps } from './Viewer.types';
import './Viewer.css';

/**
 * Displays a zoomable image, or sequence of images on the page using the 'OpenSeaDragon' library.
 **/
export default function Viewer({tileSources, className, style}:ViewerProps) {

    const idPrefix = "openseadragon";

    const ref = React.useRef<HTMLDivElement>(null);
    
    const [id, setId] = useState(uuidv4())
    
    useEffect(() => {

        OpenSeadragon({
            id: `${idPrefix}-${id}`,
            prefixUrl: "https://openseadragon.github.io/openseadragon/images/",
            tileSources: tileSources,
            sequenceMode: typeof(tileSources) != 'string' && tileSources.length > 1
        }) 

        return () => {
            OpenSeadragon.getViewer(ref.current as HTMLDivElement)?.destroy();
        }

    }, [tileSources]);

    return (
        <div ref={ref} id={`openseadragon-${id}`} className={className} style={style}></div>
    );
}