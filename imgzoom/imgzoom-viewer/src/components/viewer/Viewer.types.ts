import React, { CSSProperties } from 'react';

export interface ViewerProps {
    tileSources: string | Array<string>;
    className?: string;
    style?: CSSProperties;
}