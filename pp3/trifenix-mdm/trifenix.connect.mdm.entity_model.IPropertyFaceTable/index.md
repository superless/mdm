---
title : IPropertyFaceTable
description: trifenix.connect.mdm.entity_model.IPropertyFaceTable
---



<CodeBlock slots = 'heading, code' repeat = '1' languages = 'C#' />
#### Clase
```
IPropertyFaceTable
```

## Descripción
Interfaz para entidades que implementen un facet de busqueda.
## Constructores

no existen constructores


## Funciones

no existen funciones

## Propiedades

<CodeBlock slots = 'heading, code' repeat = '1' languages = 'C#' />
#### Clase
```
facet
```

facet de la entidad.
el facet se genera desde el index y el id, quedando = index,id
por ejemplo,
si registramos una nueva  camara con marca canon, registrariamos la marca en esta entidad indicandole el índice que
corresponda a la marca en el diccionario, el id de la entidad (guid)
y el facet que sería el index,guid
registrariamos esta campo como

```
{
   index: 3,
   id : "[guid]",
   facet : "3,[guid]"
}
```

cuando hagamos consultas traerá las agrupaciones que encuentre en base al índice y el guid,
permitiendo agrupar por entidad e identificador de esa entidad.
por ejemplo,
\`\`\`
3 => El índice que corresponde a la marca
[guid] => un guid correspondería a una entidad de tipo marca, como Canon.
\`\`\`
## Constantes
no existen campos

